using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace AsyncSocketServer
{
    public partial class FormAsyncSocketServer : Form
    {
private IPEndPoint serverIPEndPoint;                    //IP地址和端口
private int listenPort;                                 //监听端口
private Socket listenSocket;                            //监听套接字
private Socket clientSocket;                            //客户端套接字
private Thread threadAccept;                            //等待客户端连接线程
private Thread threadReceive;                           //等待接收客户端消息线程
private byte[] receiveByte = new byte[1024];            //接收消息缓存
private static ManualResetEvent lockSocket = new ManualResetEvent(false);//异步等待锁

public FormAsyncSocketServer()
{
    InitializeComponent();
}

private void bListen_Click(object sender, EventArgs e)
{
    listenPort = Int32.Parse(tBPort.Text);              //输入监听端口号
    serverIPEndPoint = new IPEndPoint(IPAddress.Any, listenPort);//实例化地址端口类
    //实例化一个TCP流式套接字
    listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    listenSocket.Bind(serverIPEndPoint);                //将套接字绑定到本地端口
    listenSocket.Listen(50);                            //将套接字设置为侦听状态
    threadAccept = new Thread(new ThreadStart(AcceptThread));//等待客户端连接线程
    threadAccept.Start();                               //启动接受连接线程
}

private void AcceptThread()
{
    while (true)
    {
        lockSocket.Reset();                             //设置异步等待锁为阻塞状态
        //异步等待客户端连接
        listenSocket.BeginAccept(new AsyncCallback(AcceptCall), listenSocket);
        lockSocket.WaitOne();                           //阻止当前线程，异步等待客户端请求连接
    }
}

private void AcceptCall(IAsyncResult asyncResult)
{
    lockSocket.Set();                                   //释放异步等待锁
    //终止异步等待，并建立新的套接字与客户端进行通信
    clientSocket = listenSocket.EndAccept(asyncResult);
    threadReceive = new Thread(new ThreadStart(ReceiveThread));//实例化接收线程
    threadReceive.Start();                              //启动接收线程
}

private void ReceiveThread()
{
    try
    {
        //异步等待接收客户端发送的数据
        clientSocket.BeginReceive(receiveByte, 0, receiveByte.Length, 0,
            new AsyncCallback(AsyncReceiveCall), clientSocket);
    }
    catch (Exception Ex)
    {
        MessageBox.Show(Ex.Message);
    }
}

private void AsyncReceiveCall(IAsyncResult asyncResult)
{
    //接收异步读取，并返回接收到消息的字节数
    int bytesRead = clientSocket.EndReceive(asyncResult);
    //将缓存中的消息转换成字符串
    string receiveString = Encoding.Default.GetString(receiveByte, 0, bytesRead);
    ShowMessage(receiveString);                         //在界面上显示接收到的消息
    //开始新一轮的异步接收
    clientSocket.BeginReceive(receiveByte, 0, receiveByte.Length, 0,
        new AsyncCallback(AsyncReceiveCall), clientSocket);
}


delegate void ShowMessageCallback(string message);      //显示接收的消息委托
//显示接收的消息
void ShowMessage(string message)
{
    if (this.InvokeRequired) this.Invoke(new ShowMessageCallback(ShowMessage), new object[] { message });
    else tBReceive.AppendText(message + "\n");
}

private void bSend_Click(object sender, EventArgs e)
{
    if (clientSocket != null && clientSocket.Connected)//判断是否已经与客户端建立连接
    {
        //将需要发送的字符串转换为Byte数组
        Byte[] sendByte = Encoding.Default.GetBytes(tBSend.Text);
        //向客户端异步发送消息
        clientSocket.BeginSend(sendByte, 0, sendByte.Length, 0,
            new AsyncCallback(SendCallback), clientSocket);
    }
}

private void SendCallback(IAsyncResult asyncResult)
{
    Socket socket = (Socket)asyncResult.AsyncState;
    int bytesSent = socket.EndSend(asyncResult);//结束挂起的异步发送，并返回发送的字节数
}

    }
}

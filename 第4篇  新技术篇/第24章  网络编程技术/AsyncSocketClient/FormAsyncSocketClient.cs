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

namespace AsyncSocketClient
{
    public partial class FormAsyncSocketClient : Form
    {
private IPAddress serverIP;                             //服务端IP地址
private int serverPort;                                 //服务端监听端口
private IPEndPoint serverIPEndPoint;                    //服务端地址端口
private Socket clientSocket;                            //客户端套接字
static ManualResetEvent lockSocket = new ManualResetEvent(false);//实例化套接字锁
byte[] receiveByte = new byte[1024];                    //异步等待锁

public FormAsyncSocketClient()
{
    InitializeComponent();
}

private void bConnect_Click(object sender, EventArgs e)
{
    serverIP = IPAddress.Parse(tBIP.Text);              //服务端IP地址
    serverPort = Int32.Parse(tBPort.Text);              //服务端监听端口
    serverIPEndPoint = new IPEndPoint(serverIP, serverPort);//实例化地址端口类
    //实例化一个TCP流式套接字
    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    //异步连接服务器
    clientSocket.BeginConnect(serverIPEndPoint, new AsyncCallback(ConnectCallback), clientSocket);
    lockSocket.WaitOne();                               //阻止当前线程，等待连接成功
}

private void ConnectCallback(IAsyncResult asyncResult)
{
    Socket client = (Socket)asyncResult.AsyncState;     //客户端套接字
    client.EndConnect(asyncResult);                     //结束连接请求
    Thread thread = new Thread(new ThreadStart(ReceiveThread));//实例化接收线程
    thread.Start();                                     //启动接收线程
    lockSocket.Set();                                   //释放异步等待锁
}

private void ReceiveThread()
{
    try
    {
        //开始异步接收服务端消息
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
    //判断是否已经与服务端建立连接
    if (clientSocket != null && clientSocket.Connected)
    {
        //将需要发送的字符串转换为Byte数组
        Byte[] sendByte = Encoding.Default.GetBytes(tBSend.Text);
        //向服务端异步发送消息
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

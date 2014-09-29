using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace SyncSocketServer
{
    public partial class FormSyncSocketServer : Form
    {
private IPEndPoint serverIPEndPoint;                            //IP地址和端口
private int listenPort;                                         //监听端口
private Socket listenSocket;                                    //监听套接字
private Socket clientSocket;                                    //客户端套接字
private Thread threadAccept;                                    //等待客户端连接线程

public FormSyncSocketServer()
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
    clientSocket = listenSocket.Accept();//同步等待客户端连接，并建立新的套接字与客户端进行通信
    if (clientSocket.Connected)                         //如果与客户端连接成功
    {
        while (true)
        {
            Byte[] receiveByte = new Byte[1024];        //存放接收到消息的缓存
            clientSocket.Receive(receiveByte, receiveByte.Length, 0);//同步接收客户端消息
            //将客户端消息转换为字符串
            string receiveString = Encoding.Default.GetString(receiveByte);
            ShowMessage(receiveString);                 //输出接收的消息
        }
    }
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
        clientSocket.Send(sendByte, sendByte.Length, 0);//向客户端同步发送消息
    }
}


    }
}

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
using System.IO;

namespace ChatRoomServer
{
    public partial class FormChatRoomServer : Form
    {
        /*
         * 应用程序可以通过 TCPClient、TCPListener 和 UDPClient 类使用传输控制协议 (TCP) 和用户数据文报协议 (UDP) 服务。这些协议类建立在 System.Net.Sockets.Socket 类的基础之上，负责数据传送的细节。(也就是说TCPClient、TCPListener 和 UDPClient 类是用来简化Socket)

    TcpClient 和 TcpListener 使用 NetworkStream 类表示网络。使用 GetStream 方法返回网络流，然后调用该流的 Read 和 Write 方法。NetworkStream 不拥有协议类的基础套接字，因此关闭它并不影响套接字。

    UdpClient 类使用字节数组保存 UDP 数据文报。使用 Send 方法向网络发送数据，使用 Receive 方法接收传入的数据文报。
         */

//实例化监听套接字
TcpListener listenerSocket = new TcpListener(IPAddress.Any, 8888);//连接侦听器
List<TcpClient> clientSockets = new List<TcpClient>();  //客户端套接字列表
Thread threadAccept;                                    //等待客户端连接线程
Thread threadReceive;                                   //等待接收客户端消息
byte[] receiveByte = new byte[1024];                    //接收消息缓存
public FormChatRoomServer()
{
    InitializeComponent();
}

protected override void OnLoad(EventArgs e)
{
    listenerSocket.Start();                             //将监听套接字设置为监听状态
    threadAccept = new Thread(new ThreadStart(AcceptThread));//实例化等待客户端连接线程
    threadAccept.Start();                               //开启等待客户端连接线程
    base.OnLoad(e);
}

public void AcceptThread()
{
    while (true)                                        //循环等待客户端连接
    {
        //等待客户端连接，并新建与客户端通信的套接字
        TcpClient clientSocket = listenerSocket.AcceptTcpClient();
        clientSockets.Add(clientSocket);//将与客户端通信的套接字添加到客户端套接字列表中
        //实例化接收客户端消息线程
        threadReceive = new Thread(new ParameterizedThreadStart(ReceiveThread));
        threadReceive.Start(clientSocket);//开启接收线程，继续等待下一个客户端的连接
    }
}
void ReceiveThread(object parameter)
{
    TcpClient clientSocket = parameter as TcpClient;        //将客户端套接字传入线程函数中
    while (true)                                            //循环接收客户端消息
    {
        NetworkStream netStream = clientSocket.GetStream();//获取与客户端通信的数据流
        //等待接收客户端消息，返回接收消息的字节数，并将消息输入到缓存中
        int len = netStream.Read(receiveByte, 0, receiveByte.Length);
        //将接收的消息转换成字符串
        string message = Encoding.Default.GetString(receiveByte, 0, len);
        string[] NameAndMessage = message.Split(':');       //分割消息字符串
        //显示用户昵称名称
        Invoke(new AddClientCallback(AddClient), new object[] { NameAndMessage[0] });
        //显示用户聊天信息
        Invoke(new AddContextDelegate(AddContext), new object[] { message });
        foreach (TcpClient s in clientSockets)              //遍历所有客户端套接字
        {
            NetworkStream nsClient = s.GetStream();         //获取客户端数据流
            nsClient.Write(receiveByte, 0, len);            //向所有客户端发送聊天内容
        }
    }
}

protected override void OnClosed(EventArgs e)
{
    listenerSocket.Stop();                                  //关闭侦听器
    foreach (var item in clientSockets) item.Close();       //关闭所有与客户端的连接
    base.OnClosed(e);
}

delegate void AddContextDelegate(string text);
public void AddContext(string text)
{
    rTBChat.AppendText(text + "\n");                        //添加聊天内容
}

delegate void AddClientCallback(string name);
public void AddClient(string name)
{
    if (!lBClient.Items.Contains(name)) lBClient.Items.Add(name);//添加用户名称
}

    }
}

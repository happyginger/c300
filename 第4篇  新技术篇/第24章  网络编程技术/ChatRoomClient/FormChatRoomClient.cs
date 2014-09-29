using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace ChatRoomClient
{
    public partial class FormChatRoomClient : Form
    {
TcpClient clientSocket = new TcpClient();               //客户端套接字
NetworkStream clientStream;                             //网络数据流
IPEndPoint serverIPEndPoint;                            //服务器地址端口
Thread threadReceive;                                   //接收线程
byte[] receiveByte = new byte[1024];                    //接收消息缓存
public FormChatRoomClient()
{
    InitializeComponent();
}

protected override void OnLoad(EventArgs e)
{
    //实例化服务器IP地址和端口
    serverIPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
    clientSocket.Connect(serverIPEndPoint);             //连接服务器
    clientStream = clientSocket.GetStream();            //获取数据流
    //实例化接收服务器消息线程
    threadReceive = new Thread(new ThreadStart(ReceiveThread));
    threadReceive.Start();                              //启动线程
    base.OnLoad(e);
}

void ReceiveThread()
{
    while (true)                                        //循环接收服务器消息
    {
        //等待接收服务器消息，返回接收消息的字节数，并将消息输入到缓存中
        int len = clientStream.Read(receiveByte, 0, receiveByte.Length);
        //将接收的消息转换成字符串
        string message = Encoding.Default.GetString(receiveByte, 0, len);
        //显示用户聊天信息
        Invoke(new AddContextDelegate(AddContext), new object[] { message });
    }
}

private void bSend_Click(object sender, EventArgs e)
{
    //将准备发送的用户名称和聊天信息转换成字节数组
    byte[] writeByte = Encoding.Default.GetBytes(tBName.Text + ":" + tBSend.Text);
    clientStream.Write(writeByte, 0, writeByte.Length);//向服务器发送聊天信息
}

delegate void AddContextDelegate(string text);
public void AddContext(string text)
{
    rTBChat.AppendText(text + "\n");                    //添加聊天内容
}

        
    }
}

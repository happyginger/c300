using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;

namespace FileTransferServer
{
    public partial class FormFileTransferServer : Form
    {

TcpListener listenerSocket = new TcpListener(IPAddress.Any, 8888);//连接侦听器
Thread threadAccept;                                    //等待客户端连接线程
TcpClient clientSocket;                                 //客户端套接字
byte[] sendFileBytes = new Byte[1024];                  //发送文件缓存

public FormFileTransferServer()
{
    InitializeComponent();
}

private void bListen_Click(object sender, EventArgs e)
{
    listenerSocket.Start();                             //将连接侦听器设置为监听状态
    threadAccept = new Thread(new ThreadStart(AcceptThread));//实例化等待客户端连接线程
    threadAccept.Start();                               //开启等待客户端连接线程
}

public void AcceptThread()
{
    while (true)
    {
        try
        {
            //等待客户端连接，并新建与客户端通信的套接字
            clientSocket = listenerSocket.AcceptTcpClient();
            if (clientSocket.Connected)
            {
                //获取与客户端通信的数据流
                NetworkStream netStream = clientSocket.GetStream();
                //读取本地文件流
                FileStream FS = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
//断点继传
//从客户端读取文件长度信息
int receiveLength = netStream.Read(sendFileBytes, 0, sendFileBytes.Length);
//获取客户端已接收的文件长度
int offset = int.Parse(Encoding.Default.GetString(sendFileBytes, 0, receiveLength));
if (offset > 0) MessageBox.Show(string.Format("文件已发送{0}字节，从断点继续向客户端发送文件！", offset.ToString()));
FS.Seek(offset, SeekOrigin.Begin);                      //将文件流的当前位置设置为客户端文件长度

                int lengthFileBytes;                    //从文件中读取的字节数
                //从文件读取字节流，直到读取完为止
                do
                {
                    //从文件中读取字节流
                    lengthFileBytes = FS.Read(sendFileBytes, 0, sendFileBytes.Length);
                    //将读取的文件字节流发送给客户端
                    netStream.Write(sendFileBytes, 0, lengthFileBytes);
                    Thread.Sleep(100);
                } while (lengthFileBytes == 1024);
                FS.Close();                             //关闭文件流
                netStream.Close();
                MessageBox.Show("文件发送完毕！");       //关闭网络数据流
            }
        }
        catch 
        {
            MessageBox.Show("文件发送中断！");
            continue; 
        }
    }
}
    }
}

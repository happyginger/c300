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

namespace FileTransferClient
{
    public partial class FormFileTransferClient : Form
    {
TcpClient clientSocket = new TcpClient();               //客户端套接字
NetworkStream clientStream;                             //网络数据流
IPEndPoint serverIPEndPoint;                            //服务器地址端口
byte[] receiveFileBytes = new byte[1024];               //接收文件数据缓存
bool stop = false;                                      //标记是否停止接收文件
public FormFileTransferClient()
{
    InitializeComponent();
}

private void bConnect_Click(object sender, EventArgs e)
{
    //实例化服务器IP地址和端口
    serverIPEndPoint = new IPEndPoint(IPAddress.Parse(tBIP.Text), int.Parse(tBPort.Text));
    clientSocket.Connect(serverIPEndPoint);             //连接服务器
    if (clientSocket.Connected)                         //如果连接成功
    {
        clientStream = clientSocket.GetStream();        //获取数据流
        FileInfo fi = new FileInfo("test.txt");         //读取文件信息

//断点续传
string lengthFile = "0";                                //已接收文件的长度
//检测需要接收的文件是否已经部分接收，如果已经存在则获取文件字节长度
if (fi.Exists) lengthFile = fi.Length.ToString();
//将文件字节长度字符串转换成字节数组
byte[] lengthBytes = Encoding.Default.GetBytes(lengthFile.ToString());
//向文件服务器发送已经接收部分文件的长度
clientStream.Write(lengthBytes, 0, lengthBytes.Length);

        //实例化文件流
        FileStream fs = new FileStream(fi.FullName, FileMode.Append, FileAccess.Write);
        int length;
        do
        {
            //从服务器接收文件字节流
            length = clientStream.Read(receiveFileBytes, 0, receiveFileBytes.Length);
            fs.Write(receiveFileBytes, 0, length);      //将获取的字节流写入文件中
            //显示接收的文件内容
            ShowMessage(Encoding.Default.GetString(receiveFileBytes, 0, length));
        } while (length == 1024 && !stop);
        fs.Close();                                     //关闭文件流
        clientStream.Close();                           //关闭网络数据流
        clientSocket.Close();                           //关闭套接字
        if (stop) MessageBox.Show("文件传输中断！");
        else MessageBox.Show("文件接收完毕！");
    }
}

delegate void ShowMessageCallback(string message);	//显示接收的消息委托
//显示接收的消息
void ShowMessage(string message)
{
    if (this.InvokeRequired) 
        this.Invoke(new ShowMessageCallback(ShowMessage), new object[] { message });
    else
    {
        rTBReceive.AppendText(message);             //将接收的文件内容显示在界面上
        Application.DoEvents();                     //刷新用户界面
    }
}

private void bStop_Click(object sender, EventArgs e)
{
    stop = true;                                    //停止接收文件
}
    }
}

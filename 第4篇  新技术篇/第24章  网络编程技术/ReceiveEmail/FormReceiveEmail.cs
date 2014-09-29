using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace ReceiveEmail
{

    public partial class FormReceiveEmail : Form
    {
readonly string pop3Address = "pop.sina.com";       //POP3服务器地址
readonly int pop3Port = 110;                        //POP3服务器端口
readonly string mailboxUser = "iloujiok@sina.com";      //电子邮箱名
readonly string mailboxPassword = "0[-9o0-p";         //电子邮箱密码
TcpClient pop3Socket;                               //用于连接POP3服务器的套接字
NetworkStream pop3Stream;                           //网络读取POP3协议数据流
StreamReader pop3Reader;                            //POP3协议数据流读取器
readonly public string CRLF = "\r\n";               //回车换行标识
string send;                                        //发送POP3协议字符串
public byte[] sendBytes;                            //发送POP3协议字节数组
string receive;                                     //接收POP3协议字符串

public FormReceiveEmail()
{
    InitializeComponent();
}
        
protected override void OnLoad(EventArgs e)
{
    Connect();                                      //连接POP3服务器
    int count = GetMailCount();                     //获取邮件数量
    lBEmail.Items.AddRange(GetMailList(1, count));  //添加邮件列表
    base.OnLoad(e);
}

protected override void OnClosed(EventArgs e)
{
    base.OnClosed(e);
}

public void Connect()
{
    pop3Socket = new TcpClient(pop3Address, pop3Port);  //实例化用于连接POP3服务器的套接字
    pop3Stream = pop3Socket.GetStream();                //获取网络读取POP3协议数据流
    pop3Reader = new StreamReader(pop3Stream);          //实例化POP3协议数据流读取器
    receive = pop3Reader.ReadLine();                    //从POP3协议数据流中读取一行POP3协议字符串
    if (!receive.StartsWith("+OK"))                     //检查是否读取成功
        throw new Exception("连接POP3服务器失败！");
    send = "USER " + this.mailboxUser + CRLF;           //POP3协议电子邮箱名字符串
    sendBytes = Encoding.ASCII.GetBytes(send);          //将字符串转换成字节数组
    pop3Stream.Write(sendBytes, 0, sendBytes.Length);   //向服务器发送电子邮箱名
    receive = pop3Reader.ReadLine();                    //从POP3服务器接收POP3协议字符串
    if (!receive.StartsWith("+OK"))                     //检查是否读取成功
        throw new Exception("邮箱用户名错误！");
    send = "PASS " + this.mailboxPassword + CRLF;       //POP3协议电子邮箱密码字符串
    sendBytes = Encoding.ASCII.GetBytes(send);          //将字符串转换成字节数组
    pop3Stream.Write(sendBytes, 0, sendBytes.Length);   //向服务器发送电子邮箱密码
    receive = pop3Reader.ReadLine();                    //从POP3服务器接收POP3协议字符串
    if (!receive.StartsWith("+OK"))                     //检查是否读取成功
        throw new Exception("邮箱密码错误！");
}

public int GetMailCount()
{
    send = "STAT" + CRLF;                               //POP3协议请求统计邮件字符串
    sendBytes = Encoding.ASCII.GetBytes(send);          //将字符串转换成字节数组
    pop3Stream.Write(sendBytes, 0, sendBytes.Length);   //向服务器发送统计邮件请求
    receive = pop3Reader.ReadLine();                    //从POP3服务器接收POP3协议字符串
    string[] tokens = receive.Split(' ');               //提取邮件数量信息
    return Convert.ToInt32(tokens[1]);
}

public string[] GetMailList(int begin, int end)
{
    string[] mails = new string[end - begin + 1];       //邮件列表
    for (int id = begin; id <= end; id++)
    {
        send = "RETR " + id + CRLF;                     //POP3协议请求邮件的全部文本
        sendBytes = Encoding.ASCII.GetBytes(send);
        pop3Stream.Write(sendBytes, 0, sendBytes.Length);
        receive = pop3Reader.ReadLine();                //接收POP3协议邮件的全部文本
        //提取邮件名称
        if (receive[0] != '-')
        {
            while (receive != "." && !receive.ToLower().StartsWith("subject:"))
            {
                receive = pop3Reader.ReadLine();
            }
            if (receive.ToLower().StartsWith("subject:"))
            {
                try
                {
                    mails[id - 1] = Encoding.UTF8.GetString(
                Convert.FromBase64String(receive.Substring(19, receive.Length - 19 - 2)));
                }
                catch (Exception)
                {
                    mails[id - 1] = receive.Substring(8, receive.Length - 8 - 2);
                }
                while (pop3Reader.ReadLine() != ".") { }
            }
        }
    }
    return mails;
}

public string GetMail(int id)
{
    StringBuilder content = new StringBuilder();
    try
    {
        send = "RETR " + id + CRLF;                     //POP3协议请求邮件的全部文本
        sendBytes = Encoding.ASCII.GetBytes(send);
        pop3Stream.Write(sendBytes, 0, sendBytes.Length);
        receive = pop3Reader.ReadLine();
        //提取邮件全部文本
        if (receive[0] != '-')
        {
            while (receive != ".")
            {
                receive = pop3Reader.ReadLine();
                content.Append(receive + CRLF);
            }
        }
        return content.ToString();
    }
    catch (Exception Ex) { throw Ex; }
}

public void DeleteMail(int id)
{
    send = "DELE" + id + CRLF;
    sendBytes = Encoding.ASCII.GetBytes(send);
    pop3Stream.Write(sendBytes, 0, sendBytes.Length);
    receive = pop3Reader.ReadLine();
    if (!receive.StartsWith("+OK"))
        throw new Exception("邮件删除失败！");
}

public void CloseMail()
{
    send = "QUIT" + CRLF;
    sendBytes = Encoding.ASCII.GetBytes(send);
    pop3Stream.Write(sendBytes, 0, sendBytes.Length);
    pop3Stream.Close();
    pop3Reader.Close();
}

private void lBEmail_DoubleClick(object sender, EventArgs e)
{
    rTBEmail.Text = GetMail(lBEmail.SelectedIndex + 1);
}
    }
}

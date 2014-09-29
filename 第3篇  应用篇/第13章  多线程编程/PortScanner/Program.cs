using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace PortScanner
{
    class Program
    {
        static List<int> ports = new List<int>();
        const string ip = "192.168.1.101";
        static void Main(string[] args)
        {
            Console.Title = "端口扫描工具";

Console.WriteLine("开始扫描{0}...", ip);
for (int port = 1; port <= 1024; port++)                //扫描1到1024号端口
{
    ThreadPool.QueueUserWorkItem(new WaitCallback(PortScan), port);//创建端口扫描线程
}

            Console.ReadLine();
        }

static void PortScan(object port)                       //端口扫描线程函数
{
    try
    {
        TcpClient client = new TcpClient();             //创建TCP套接字
        client.Connect(ip, (int)port);                  //尝试与指定IP和端口连接
        if (client.Connected)                           //连接成功
        {
            Console.WriteLine("端口{0}开放！", port);
        }
    }
    catch { }                                           //连接失败
    if ((int)port == 1024) Console.WriteLine("扫描完毕！");
}
    }
}

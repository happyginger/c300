using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace BroadcastServer
{
    class Program
    {
        /*广播的一个缺点就是，会影响到所有的子网内的计算机，即使对此广播消息不感兴趣的计算机。多播可以解决这个问题。
 
多播采用推进技术(浏览网页属于拉拔技术，同样属于推进技术的有发送Email服务)。多播也叫组播，如果用户加入某个多播组，那么，它就能够收到发往这个组的数据。
 
组播应用D类IP地址（224.0.0.0-239.255.255.255），但不是说从每个组播的组接收数据的计算机要具有D类IP地址。组播的组需要D类IP地址来标示。D类IP地址分成几断，某些具有特殊用途。
 
组播有两种应用模式。一种是一个组中的任意一个用户发信息，其余用户都能够接收，各个用户的地位是等价的。另一种是只一个用户发信息，其余用户只负责接收信息。
 
组播的拓扑结构是一个树状结构。
         */
        static void Main(string[] args)
        {
            Program p = new Program();

            p.BroadcastListen();

            Console.Read();
        }

void BroadcastListen()
{
//实例化一个UDP数据报套接字，用于接收消息
Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
//实例化一个用于侦听局域网内部所有IP地址和指定端口类
IPEndPoint serverIPEndPoint = new IPEndPoint(IPAddress.Any, 8888);
EndPoint serverEndPoint = (EndPoint)serverIPEndPoint;   //将地址端口类转换为网络地址类
serverSocket.Bind(serverEndPoint);                      //将套接字绑定这个网络地址上
while (true)                                            //循环接收数据
{
    Console.WriteLine("等待局域网广播消息...");
    byte[] receiveByte = new byte[1024];                //设置接收数据缓冲
    //接收数据，并确把数据设置到缓冲里面
    int len = serverSocket.ReceiveFrom(receiveByte, ref serverEndPoint);
    Console.WriteLine("从客户端" + serverEndPoint.ToString() + "收到消息：");
    //将接收的消息转换成字符串，并追加时间，显示出来
    Console.WriteLine(Encoding.Default.GetString(receiveByte, 0, len) + " " + DateTime.Now.ToString());
    //将发送字符串转换成字节数据
    byte[] sendMessage = Encoding.Default.GetBytes("hello client");
    serverSocket.SendTo(sendMessage, serverEndPoint);   //向客户端回复消息
    Console.WriteLine("向客户端回复消息：hello client");
}
}
        //组播是通过交换机实现的。。。

        //void MulticastListen()
        //{
        //    IPAddress groupIPAddress = IPAddress.Parse("224.168.100.2");
        //    int groupPort = 11000;
        //    IPEndPoint serverIPEndPoint = new IPEndPoint(groupIPAddress, groupPort);

        //    UdpClient listener = new UdpClient();
        //    try
        //    {
        //        listener.JoinMulticastGroup(groupIPAddress,10);
        //        //listener.Connect(serverIPEndPoint);
        //        while (true)
        //        {
        //            byte[] receiveBytes = listener.Receive(ref serverIPEndPoint);
        //            Console.WriteLine("received broadcast from {0} : \n{1}\n",
        //            serverIPEndPoint.ToString(),
        //            Encoding.Default.GetString(receiveBytes, 0, receiveBytes.Length));
        //        }

        //    }
        //    catch (Exception Ex)
        //    {
        //        Console.WriteLine(Ex.Message);
        //    }
        //    listener.Close();
        //}

        private IPAddress multicastIP = IPAddress.Parse("224.110.10.1");
        private int port = 5001;
        public void MulticastListen()
        {
            Console.WriteLine("Reciever Start");
            UdpClient receiveUdp = new UdpClient(this.port);
            try
            {
                receiveUdp.JoinMulticastGroup(this.multicastIP, 10);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            IPEndPoint remoteHost = null;
            while (true)
            {
                try
                {
                    byte[] bytes = receiveUdp.Receive(ref remoteHost);
                    string str = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    Console.WriteLine(str);
                }
                catch
                {
                    Console.WriteLine("Reciever Close");
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace BroadcastClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "局域网广播客户端";

            Program p = new Program();

            p.Broadcast();
            //p.Multicast();

            Console.Read();
        }

        void Broadcast()
        {
//实例化一个UDP数据报套接字，用于向局域网发送广播
Socket broadcastSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
//初始化一个发送广播和指定接收端口端口的地址端口类
IPEndPoint broadcastIPEndPoint = new IPEndPoint(IPAddress.Broadcast, 8888);
//设置套接字以广播形式发送
broadcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
Console.WriteLine("向局域网广播消息：hello world");
//将发送消息字符串转换成字节数组
byte[] sendByte = Encoding.Default.GetBytes("hello world");
broadcastSocket.SendTo(sendByte, broadcastIPEndPoint);  //向局域网发送广播
//将地址端口类转换为网络地址类
EndPoint clientEndPoint = (EndPoint)broadcastIPEndPoint;
byte[] receiveByte = new byte[1024];                    //设置接收数据缓冲
//接收数据，并确把数据设置到缓冲里面
int len = broadcastSocket.ReceiveFrom(receiveByte, ref clientEndPoint);
Console.WriteLine("从服务器" + clientEndPoint.ToString() + "收到消息：");
//将接收的消息转换成字符串，并追加时间，显示出来
Console.WriteLine(Encoding.Default.GetString(receiveByte, 0, len) + " " + DateTime.Now.ToString());
broadcastSocket.Close();                                //关闭套接字
        }

        //void Multicast(string message)
        //{
        //    UdpClient sender = new UdpClient();
        //    IPAddress groupIPAddress = IPAddress.Parse("224.168.100.2");
        //    int groupPort = 11000;
        //    IPEndPoint clientIPEndPoint = new IPEndPoint(groupIPAddress, groupPort);
        //    sender.EnableBroadcast = true;
        //    try
        //    {
        //        Console.WriteLine("Sending datagram : {0}", message);
        //        byte[] sendBytes = Encoding.Default.GetBytes(message);
        //        sender.Send(sendBytes, sendBytes.Length, clientIPEndPoint);
        //        sender.Close();
        //    }
        //    catch (Exception Ex)
        //    {
        //        Console.WriteLine(Ex.Message);
        //    }
        //}
        private IPAddress multicastIP = IPAddress.Parse("224.110.10.1");
        private int port = 5001;
        public void Multicast()
        {
            Console.WriteLine("Sender Start");
            IPEndPoint multicastIep = new IPEndPoint(multicastIP, port);
            UdpClient sendUdpClient = new UdpClient();
            sendUdpClient.EnableBroadcast = true;
            string sendString = "How   are   you";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(sendString);
            try
            {
                sendUdpClient.Send(bytes, bytes.Length, multicastIep);
            }
            catch
            {
                Console.WriteLine("send error");
            }
            finally
            {
                sendUdpClient.Close();
                Console.WriteLine("Sender Close");
            }
        }

    }
}

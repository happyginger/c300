using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;
using RemoteClass;

namespace RemoteClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "远程过程调用客户端";

TcpChannel tcpChannel = new TcpChannel(0);              //创建一个Tcp通道
ChannelServices.RegisterChannel(tcpChannel, false);     //注册通道服务
ChannelDataStore data = (ChannelDataStore)tcpChannel.ChannelData;//获取本地通道信息
string ChannelUris = data.ChannelUris[0];               //获取本地通道地址
Remote.HelloCallback += new EventHandler<EventArgsHello>(Remote_HelloCallback);
Remote remote = (Remote)Activator.GetObject(typeof(Remote),//获取远程对象代理
    "tcp://localhost:8888/HelloServer");
RemotingConfiguration.RegisterWellKnownServiceType(typeof(Remote), "HelloClient", WellKnownObjectMode.Singleton);//注册Remote类
remote.Hello("客户端", "服务端", "您好！", ChannelUris);//调用远程对象Hello方法

            Console.Read();
        }

static void Remote_HelloCallback(object sender, RemoteClass.EventArgsHello e)
{
    Console.WriteLine("{0} 对 {1} 说 {2}", e.From, e.To, e.Something);
}



    }
}

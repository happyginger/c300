using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;
using RemoteClass;

namespace RemoteServer
{
    class Program
    {
static Remote remoteClass;                              //远程对象代理
static string ChannelUris;                              //本地通道地址
static ChannelDataStore data;                           //通道信息
static TcpChannel tcpChannel;                           //Tcp通道
        static void Main(string[] args)
        {
            Console.Title = "远程过程调用服务端";

tcpChannel = new TcpChannel(8888);                      //创建Tcp通道
ChannelServices.RegisterChannel(tcpChannel, false);     //注意通道服务
data = (ChannelDataStore)tcpChannel.ChannelData;        //获取通道信息
ChannelUris = data.ChannelUris[0];                      //获取通道地址
Remote.HelloCallback += new EventHandler<EventArgsHello>(Remote_HelloCallback);
RemotingConfiguration.RegisterWellKnownServiceType(     //注册Remote类型
    typeof(Remote), "HelloServer", WellKnownObjectMode.Singleton);

            Console.Read();
        }

static void Remote_HelloCallback(object sender, EventArgsHello e)
{
    Console.WriteLine("{0} 对 {1} 说 {2}", e.From, e.To, e.Something);
    object obj = tcpChannel.ChannelData;                //获取客户端地址
    if (remoteClass == null)
        remoteClass = (Remote)Activator.GetObject(typeof(Remote), e.ChannelUris + "/HelloClient");  //获取远程对象代理
    remoteClass.Hello("服务端", "客户端", "您好！", ChannelUris);//调用远程对象Hello方法
}
    }
}

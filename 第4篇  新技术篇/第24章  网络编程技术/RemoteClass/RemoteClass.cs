using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Permissions;

namespace RemoteClass
{
[Serializable]
public class EventArgsHello : EventArgs
{
    public readonly string From;                        //消息发送者
    public readonly string To;                          //消息接收者
    public readonly string Something;                   //消息内容
    public readonly string ChannelUris;                 //发送者通道地址
    public readonly string Port;                        //发送者通道端口
    public EventArgsHello(string from, string to, string something, string uri)
    {
        this.From = from;
        this.To = to;
        this.Something = something;
        this.ChannelUris = uri;
    }
}
[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
public class Remote : MarshalByRefObject
{
    public static event EventHandler<EventArgsHello> HelloCallback;
    public void Hello(string from, string to, string something, string uri)
    {
        if (HelloCallback != null) HelloCallback(this, new EventArgsHello(from, to, something, uri));
    }
}
}

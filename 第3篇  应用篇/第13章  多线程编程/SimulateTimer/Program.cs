using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimulateTimer
{
    class Program
    {
class Info                                              //提醒信息类
{
    public int TimeOut { get; set; }                    //事件提醒超时时间
    public string Something { get; private set; }       //需要提醒的事件
    public Timer Timer { get; private set; }            //定时器
    public Info(int timeout, string something)
    {
        this.TimeOut = timeout;
        this.Something = something;
        this.Timer = new Timer(new TimerCallback(Remind), this, 0, 1000);//创建定时器
    }
}
static void Main(string[] args)
{
    Console.Title = "模拟定时器";

while (true)
{
    Console.WriteLine("请输入倒计时时间（单位：秒）：");
    int timeout = int.Parse(Console.ReadLine());
    Console.WriteLine("请输入提醒的事件：");
    string something = Console.ReadLine();
    new Info(timeout, something);                   //创建事件信息类，启动事件提醒线程
    Console.ReadLine();
}

    Console.ReadLine();
}

static void Remind(object state)                        //事件提醒线程函数
{
    Info info = state as Info;                          //提醒信息
    if (info.TimeOut == 10) 
        Console.WriteLine("离{0}还有{1}秒钟！", info.Something, info.TimeOut--);//提前10秒提醒
    else if (info.TimeOut > 0) info.TimeOut--;          //将超时时间减去1秒
    else
    {
        Console.WriteLine("该{0}了！",info.Something);   //提醒该做某事
        info.Timer.Dispose();                           //释放定时器
    }
}
    }
}

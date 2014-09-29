using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GroupMessages
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Title = "模拟群发祝福短信";

for (int i = 0; i < 10; i++)                            //给十个用户发送短信
{
    int number = random.Next(100000000);                //随机生成手机号码
    Thread thread = new Thread(new ParameterizedThreadStart(SendMessage));//创建线程
    thread.Start("138" + number);                       //启动线程
}

            Console.ReadLine();
        }


static void SendMessage(object user)                    //发送短信线程函数
{
    Console.WriteLine("正在向用户{0}发送祝福短信：中秋节快乐！", user);
    Thread.Sleep(random.Next(10));                     //随机等待发送短信完成
    Console.WriteLine("用户{0}接收短信成功！", user);
}
    }
}

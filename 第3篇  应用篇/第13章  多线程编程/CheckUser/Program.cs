using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CheckUser
{
    class Program
    {
static Random random = new Random();
//在线用户列表，Key为用户编号，Value为用户在线时长
static Dictionary<int, int> users = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            Console.Title = "检测用户在线时间";

Timer timerCheck = new Timer(new TimerCallback(Check), null, 0, 1000);//创建并启动定时器
ThreadPool.QueueUserWorkItem(new WaitCallback(Login));  //创建并启动用户登陆线程

            Console.ReadLine();
        }

static void Check(object state)                         //检测用户在线时长线程函数
{
    lock (users)
    {
        Console.Clear();
        for (int user = 0; user < 20; user++)           //遍历所有的用户
        {
            if (users.ContainsKey(user))                //如果用户已经登陆
            {
                //输出用户在线时长，并将用户在线时长延长1秒
                Console.WriteLine("{0}号用户在线时长为{1}秒", user, users[user]++);
            }
        }
    }
}

static void Login(object state)                         //用户登陆线程函数
{
    while (true)
    {
        lock (users)
        {
            int user = random.Next(20);                 //随机生成登陆的用户编号
            if (!users.ContainsKey(user)) users.Add(user, 1);//如果用户未登陆，就将用户添加到用户列表中
            else users.Remove(user);                        //如果用户已经登陆，就将用户从用户列表中删除
        }
        Thread.Sleep(random.Next(1000));                //随机生成用户登陆时间
    }
}
    }
}

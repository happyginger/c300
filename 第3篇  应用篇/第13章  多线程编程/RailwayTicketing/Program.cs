using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RailwayTicketing
{
    class Program
    {
        static Random random = new Random();
        static List<int> seats = new List<int>();//待售列车座位表
        static void Main(string[] args)
        {
            Console.Title = "模拟铁路售票系统";

for (int seat = 1; seat < 101; seat++) seats.Add(seat); //分配100个列车座位
for (int i = 1; i < 6; i++)                             //创建5个售票窗口同时售票
{
    ThreadPool.QueueUserWorkItem(new WaitCallback(Ticketing), i);//创建并启动售票线程
}

            Console.ReadLine();
        }

static void Ticketing(object number)                    //售票线程函数
{
    while (true)
    {
        int seat;
        lock (seats)                                    //锁定待售座位表
        {
            Console.WriteLine("{0}号窗口正在获取还未售出的座位...", number);
            if (seats.Count == 0)                       //如果待售座位表为空，则票已售完
            {
                Console.WriteLine("车票已售完！{0}号窗口停止售票！", number);
                break;
            }
            seat = seats[random.Next(seats.Count)];     //随机获取一个可以用的座位
            seats.Remove(seat);                         //将准备售出的座位从待售座位表中删除
        }
        Thread.Sleep(random.Next(1000));                //随机等待售票完成
        Console.WriteLine("{0}号窗口售出{1}号座位车票！", number, seat);
    }
}


    }
}

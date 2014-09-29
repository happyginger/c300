using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProducerConsumer
{
    class Program
    {
        static Random random = new Random();
static Queue<int> products = new Queue<int>();          //产品队列
static int product = 0;                                 //当前产品编号
        static void Main(string[] args)
        {
            Console.Title = "生产者与消费者模型";

for (int i = 1; i < 6; i++)                             //创建5个生产者和5个消费者
{
    ThreadPool.QueueUserWorkItem(new WaitCallback(Produce), i);//创建并启动生产线程
    ThreadPool.QueueUserWorkItem(new WaitCallback(Consume), i);//创建并启动消费线程
}

            Console.ReadLine();
        }

static void Produce(object number)                      //生产产品线程函数
{
    while (product < 100)
    {
        lock (products)
        {
            Console.WriteLine("生产者{0}正在生产编号为{1}的产品...", number, product);
            products.Enqueue(product++);                //生产编号为product的产品
        }
        Thread.Sleep(random.Next(1000));                //随机等待生产完成
    }
}

static void Consume(object number)                      //消耗产品线程函数
{
    while (product < 100)
    {
        lock (products)
        {
            if (products.Count == 0)                    //如果产品队列中没有产品则等待
                Console.WriteLine("消费者{0}正在等待产品...", number);
            else
                Console.WriteLine("消费者{0}正在消耗编号为{1}的产品...", number, products.Dequeue());
        }
        Thread.Sleep(random.Next(1000));                //随机等待消耗完成
    }
}
    }
}

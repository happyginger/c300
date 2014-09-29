using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Maximum
{
    class Program
    {
        static Random random = new Random();
const int DataLength = 100000000;                       //数据数量
static int[] data = new int[DataLength];                //数据表
static int finish = 0;                                  //线程完成标识
static AutoResetEvent locker = new AutoResetEvent(false);//线程锁
static int maximum = int.MinValue;                      //数据最大值标识
        static void Main(string[] args)
        {
            Console.Title = "海量数据求最大值";

Console.WriteLine("随机生成{0}个整数...", DataLength);
for (int i = 0; i < 10; i++)                            //创建10个线程生成随机数
{
    Thread thread = new Thread(new ParameterizedThreadStart(RandomData));
    thread.Start(i);
}
locker.WaitOne();                                       //等待所有线程执行完毕
Console.WriteLine("所有数据生成完成...");

finish = 0;
locker.Reset();
for (int i = 0; i < 10; i++)                            //创建10个线程计算整数最大值
{
    Thread thread = new Thread(new ParameterizedThreadStart(MaximaumData));
    thread.Start(i);
}
locker.WaitOne();                                       //等待所有线程执行完毕
Console.WriteLine("最大值为{0}", maximum);


            Console.ReadLine();
        }

static void RandomData(object region)                   //生成随机数线程函数
{
    int begin = (int)region * DataLength / 10;          //数据表区域起始索引
    int end = ((int)region + 1) * DataLength / 10;      //数据表区域终止索引
    Console.WriteLine("随机生成{0}至{1}的数据...", begin, end);
    for (int i = begin; i < end; i++)
    {
        data[i] = random.Next(int.MinValue, int.MaxValue);//随机生成整数
    }
    Console.WriteLine("{0}至{1}的数据生成完成！", begin, end);
    finish++;
    if (finish == 10) locker.Set();                     //释放线程锁
}

static void MaximaumData(object region)                 //求解最大值线程函数
{
    int begin = (int)region * DataLength / 10;          //数据表区域起始索引
    int end = ((int)region + 1) * DataLength / 10;      //数据表区域终止索引
    for (int i = begin; i < end; i++) maximum = Math.Max(maximum, data[i]);
    finish++;
    if (finish == 10) locker.Set();                     //释放线程锁
}

    }
}

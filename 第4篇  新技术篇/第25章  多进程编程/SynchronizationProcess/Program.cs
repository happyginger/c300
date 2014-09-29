using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationProcess
{
    class Program
    {
        static Mutex SyncLock;     						//进程互斥锁

static void Main(string[] args)
{
    Console.Title = "实现进程间同步";
try
{
    SyncLock = Mutex.OpenExisting("SyncProcess");       //如果互斥对象已存在则打开该互斥对象
}
catch (WaitHandleCannotBeOpenedException)
{
    SyncLock = new Mutex(false, "SyncProcess");         //如果互斥对象不存在则创建一个新的互斥对象
}
while (true)
{
    Console.WriteLine("当前进程等待获取互斥对象访问权。");
    SyncLock.WaitOne();
    Console.WriteLine("获取互斥对象访问权，按Enter键释放互斥对象。\n输入exit键释放互斥对象并退出程序。");
    if (Console.ReadLine() == "exit")
    {
        SyncLock.ReleaseMutex();                        //释放互斥锁
        break;
    }
    SyncLock.ReleaseMutex();                            //释放互斥锁
    Console.WriteLine("已释放互斥对象访问权。");
}
}
    }
}

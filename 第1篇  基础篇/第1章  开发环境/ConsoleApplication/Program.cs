using System;                                           //引用系统命名空间

namespace ConsoleApplication                            //定义本控制台应用程序命名空间
{
    class Program                                       //定义Program类
    {
        /// 每一个控制台程序都开始于Program类的Main函数
        /// <param name="args">应用程序启动时传递的参数</param>
        static void Main(string[] args)
        {
Console.Title = "hello world";                          //控制台窗体标题
Console.WriteLine("hello world");                       //在控制台窗口上输出hello world
Console.ReadLine();                                     //等待从控制台输入一行字符串
        }
    }
}

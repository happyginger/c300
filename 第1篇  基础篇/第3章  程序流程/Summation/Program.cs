using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "求表达式1-2+3-4+…-100的值";
Console.WindowWidth = 40;                               //设置控制台窗口宽度
Console.BufferWidth = 40;                               //设置控制台缓冲区宽度
int sum = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)                                     //如果为偶数
    {
        sum -= i;                                       //减去偶数
        if (i == 100)
            Console.Write("{0} = {1}", i, sum);
        else
            Console.Write("{0} + ", i);                 //偶数后面为+
    }
    else                                                //如果为奇数
    {
        sum += i;                                       //加上奇数
        Console.Write("{0} - ", i);                     //奇数后面为-
    }
}

            Console.Read();
        }
    }
}

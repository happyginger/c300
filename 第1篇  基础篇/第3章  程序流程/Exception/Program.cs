using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "输入数据不规范时捕获异常";
int number = 0;
while (true)
{
    try
    {
        Console.WriteLine("请输入一个整数：");
        number = int.Parse(Console.ReadLine());         //当输入的不是整数时抛出异常
        if (number <0 || number > 100)                  //当数值不在0到100之间时抛出异常
            throw new ArgumentOutOfRangeException("number", "数值应该在100以内");
    }
    catch (ArgumentOutOfRangeException e)               //捕获“数据不在指定范围”异常
    {
        Console.WriteLine(e.Message);                   //输出异常消息的内容
        continue;                                       //重新输入整数
    }
    catch (FormatException e)                           //捕获“字符串格式不正确”异常
    {
        Console.WriteLine(e.Message);                   //输出异常消息的内容
        number = 100;                                   //数值取最大值
        continue;                                       //重新输入整数
    }
    finally
    {
        Console.WriteLine("输入整数为{0}", number);      //输出数值
    }
    break;
}
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将两个数的值交换";

Console.WriteLine("请输入第一个数：");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("请输入第二个数：");
int number2 = int.Parse(Console.ReadLine());
Program.Exchange(ref number1, ref number2);
Console.WriteLine("将两个数进行交换...");
Console.WriteLine("第一个数等于：{0} 第二个数等于：{1}", number1, number2);

            Console.ReadLine();
        }

static void Exchange(ref int number1, ref int number2)
{
    int temp = number2;                                 //将第二个数存放到临时变量中
    number2 = number1;                                  //将第一个数的值赋给第二个数
    number1 = temp;                                     //将临时变量中第二个数的值赋给第一个数
}
    }
}

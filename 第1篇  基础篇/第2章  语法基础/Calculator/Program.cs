using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "实现简单计算器";

Console.WriteLine("请输入第一个数：");
int Number1 = int.Parse(Console.ReadLine());            //从控制台输入第一个数
Console.WriteLine("请输入算术运算符：");
string Operator = Console.ReadLine();                   //从控制台输入运算符
Console.WriteLine("请输入第二个数：");
int Number2 = int.Parse(Console.ReadLine());            //从控制台输入第二个数
int result = 0;                                         //运算结果
switch (Operator)
{
    case "+":
        result = Number1;                               //将数一赋值给运算结果
        result += Number2;                              //将数二与运算结果相加并赋值给运算结果
        break;
    case "-":
        result = Number1 - Number2;                     //减法运算
        break;
    case "*":
        result = Number1 * Number2;                     //乘法运算
        break;
    case "/":
        result = Number1 / Number2;                     //除法运算
        break;
    case "%":
        result = Number1 % Number2;                     //取模运算
        break;
    default:
        Console.WriteLine("运算符输入错误!");
        return;
}
Console.WriteLine("{0} {1} {2} = {3}", Number1, Operator, Number2, result);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "判断1到10之间的素数和合数";

Console.WriteLine("请输入1到10之间的整数：");
int prime = int.Parse(Console.ReadLine());
switch (prime)
{
    case 1:
    case 2:
    case 3:
    case 5:
    case 7:
        Console.WriteLine("{0}为素数", prime);
        break;
    case 4:
    case 6:
    case 8:
    case 9:
    case 10:
        Console.WriteLine("{0}为合数", prime);
        break;
    default:
        break;
}
            Console.Read();
        }
    }
}

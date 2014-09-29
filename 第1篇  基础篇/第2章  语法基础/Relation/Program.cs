using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Relation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "输出两个数之间的关系";

Console.WriteLine("请输入第一个数：");
int Number1 = int.Parse(Console.ReadLine());            //从控制台输入第一个数
Console.WriteLine("请输入第二个数：");
int Number2 = int.Parse(Console.ReadLine());            //从控制台输入第二个数

if (Number1 == Number2)                                 //如果两个数相等
    Console.WriteLine("{0} 等于 {1}", Number1, Number2);
else if (Number1 > Number2)                             //如果数一大于数二
    Console.WriteLine("{0} 大于 {1}", Number1, Number2);
else if (Number1 < Number2)                             //如果数一小于数二
    Console.WriteLine("{0} 小于 {1}", Number1, Number2);

            Console.ReadLine();
        }
    }
}

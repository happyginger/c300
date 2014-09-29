using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "求三个数中的最大值";

Console.WriteLine("请输入第一个数：");
int Number1 = int.Parse(Console.ReadLine());            //从控制台输入第一个数
Console.WriteLine("请输入第二个数：");
int Number2 = int.Parse(Console.ReadLine());            //从控制台输入第二个数
Console.WriteLine("请输入第三个数：");
int Number3 = int.Parse(Console.ReadLine());            //从控制台输入第三个数
//对三个数互相比较求出最大的数
int max = Number1 > Number3 ? Number1 > Number2 ? Number1 : Number2 : Number3;
Console.WriteLine("{0} {1} {2}中最大值为{3}", Number1, Number2, Number3, max);

            Console.Read();
        }
    }
}

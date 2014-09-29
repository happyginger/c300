using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Float
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "从控制台输出浮点类型";

float Float = 123.456789f;                              //单精度浮点型
double Double = 123.456789123456789d;                   //双精度浮点型
decimal Decimal = 123.456789123456789123456789m;        //高精度浮点型

Console.WriteLine("单精度浮点型\t{0}", Float);
Console.WriteLine("双精度浮点型\t{0}", Double);
Console.WriteLine("高精度浮点型\t{0}", Decimal);

            Console.Read();
        }
    }
}

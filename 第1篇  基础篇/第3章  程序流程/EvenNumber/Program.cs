using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "输出1到20之间的偶数";
int i = 0;
do
{
    if (++i % 2 != 0) continue;
    Console.Write(i);
    if (i % 5 == 0) Console.WriteLine();
    else Console.Write("\t");
} while (i < 20);

            Console.Read();
        }
    }
}

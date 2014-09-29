using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "输出字符串中的每个字符";
Console.WriteLine("请输入字符串：");
string String = Console.ReadLine();
foreach (char c in String)
{
    Console.WriteLine(c);
}
            Console.ReadLine();
        }
    }
}

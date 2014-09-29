using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将古诗分行输出";

string poetry = "日照香炉生紫烟，遥看瀑布挂前川。飞流直下三千尺，疑是银河落九天。\n";
Console.WriteLine(poetry);                              //输出古诗
foreach (char item in poetry)
{
    Console.Write(item);                                //输出古诗中每一个字和标点
    Console.Write("\t");                                //输出制表符
    if (Char.IsPunctuation(item)) Console.Write("\n\n");//如果字符为标点则换行
}

            Console.Read();
        }
    }
}

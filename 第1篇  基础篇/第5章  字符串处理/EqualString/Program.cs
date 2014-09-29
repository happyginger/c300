using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " 判断古诗默写是否正确";

Console.WriteLine("请默写李白的《黄鹤楼送孟浩然之广陵》：");
string[] poetry = new string[] {"故人西辞黄鹤楼","烟花三月下扬州","孤帆远影碧空尽","惟见长江天际流"};
for (int i = 0; i < poetry.Length; i++)
{
    Console.Write("请默写第{0}句：", i + 1);
    string sentence = Console.ReadLine();               //从控制台输入诗句
    if (sentence.Equals(poetry[i]))                     //判断诗句输入是否正确
        Console.WriteLine("第{0}句默写正确！", i + 1);
    else
        Console.WriteLine("第{0}句默写错误！正确答案为：{1}", i + 1, poetry[i]);
}
            

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将古诗颠倒输出";

Console.WriteLine("《早发白帝城》");
string[] poetry = new string[]{ "朝辞白帝彩云间","千里江陵一日还","两岸猿声啼不住","轻舟已过万重山"};
foreach (string sentence in poetry)
{
    char[] chars = sentence.ToCharArray();              //将字符串转化成字符数组
    foreach (char item in chars.Reverse()) Console.Write(item);//将字符串中的字符颠倒输出
    Console.WriteLine();
}
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CheckIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "验证IP地址字符串格式";
string pattern =                                        //正则表达式字符串
@"^((2[5][0-5]|2[0-4][0-9]|1\d{2}|[1-9]?\d)\.){3}(2[5][0-5]|2[0-4][0-9]|1\d{2}|[1-9]?\d)$";
Regex regex = new Regex(pattern);                       //创建正则表达式对象

Console.WriteLine("请输入IP地址：");
while (!regex.IsMatch(Console.ReadLine()))              //判断IP地址格式是否正确
{
    Console.WriteLine("IP地址格式错误！");
    Console.WriteLine("请输入IP地址：");
}
Console.WriteLine("IP地址格式正确！");

            Console.ReadLine();
        }
    }
}

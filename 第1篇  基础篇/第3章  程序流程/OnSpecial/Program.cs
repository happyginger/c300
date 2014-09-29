using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnSpecial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "输出酒店指定星期特价菜";
//switch (表达式)
//{
//    case 常量表达式1:
//        语句块1
//        break;
//    case 常量表达式2:
//        语句块2
//        break;
//        …………
//    case 常量表达式n:
//        语句块n
//        break;
//    default:
//        语句块n+1
//        break;
//}


Console.WriteLine("请输入星期：");
Week week = (Week)byte.Parse(Console.ReadLine());
switch (week)
{
    case Week.Sunday:
        Console.WriteLine("星期日特价菜：爆炒牛肉18元");
        break;
    case Week.Monday:
        Console.WriteLine("星期一特价菜：啤酒鸭26元");
        break;
    case Week.Tuesday:
        Console.WriteLine("星期二特价菜：红烧肉20元");
        break;
    case Week.Wednesday:
        Console.WriteLine("星期三特价菜：回锅肉16元");
        break;
    case Week.Thursday:
        Console.WriteLine("星期四特价菜：水煮鱼24元");
        break;
    case Week.Friday:
        Console.WriteLine("星期五特价菜：剁椒鱼头30元");
        break;
    case Week.Saturday:
        Console.WriteLine("星期六特价菜：手撕包菜12元");
        break;
    default:
        break;
}
            Console.Read();
        }

enum Week : byte
{
    Sunday,                                             //星期日
    Monday,                                             //星期一
    Tuesday,                                            //星期二
    Wednesday,                                          //星期三
    Thursday,                                           //星期四
    Friday,                                             //星期五
    Saturday                                            //星期六
}
    }
}

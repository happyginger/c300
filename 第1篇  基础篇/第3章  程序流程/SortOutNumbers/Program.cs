using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortOutNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将三个数从小到大输出";

Console.WriteLine("请输入第1个数:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("请输入第2个数:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("请输入第3个数:");
int c = int.Parse(Console.ReadLine());
if (a < b)                                              //如果a小于b
{
    if (b < c)                                          //如果b小于c
        Console.WriteLine("从小到大为：{0} {1} {2}", a, b, c);
    else if (a < c)                                     //如果c小于b大于a
        Console.WriteLine("从小到大为：{0} {1} {2}", a, c, b);
    else                                                //如果c小于b且小于a
        Console.WriteLine("从小到大为：{0} {1} {2}", c, a, b);
}
else                                                    //如果a大于b
{
    if (c < b)                                          //如果c小于b
        Console.WriteLine("从小到大为：{0} {1} {2}", c, b, a);
    else if (a > c)                                     //如果c大于b小于a
        Console.WriteLine("从小到大为：{0} {1} {2}", b, c, a);
    else                                                //如果c大于b且大于a
        Console.WriteLine("从小到大为：{0} {1} {2}", b, a, c);
}
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "模拟超市商品打折";

Console.WriteLine("请输入商品价格：");
decimal price = decimal.Parse(Console.ReadLine());      //商品价格
if (price >= 100)                                       //价格满100打9.5折
{
    price *= 0.95m;
}
Console.WriteLine("应付金额{0:C2}", price);
            Console.ReadLine();
        }
    }
}

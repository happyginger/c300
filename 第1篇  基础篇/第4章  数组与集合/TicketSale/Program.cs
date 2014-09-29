using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "列车售票记录";
Random random = new Random();
bool[,] seats = new bool[20, 5];                        //座位状态表
for (int c = 0; c < 20; c++)
{
    for (int r = 0; r < 5; r++)
    {
        seats[c, r] = random.Next(2) >= 1;              //随机生成座位状态
        //输出座位状态
        Console.Write("[{0:D3}{1}]  ", c * 5 + r + 1, seats[c, r] ? "已售" : " 空 ");
    }
    Console.WriteLine();
}

Console.WriteLine("请输入座号：");
int number = int.Parse(Console.ReadLine());             //输入座位号
if (seats[(number - 1) / 20, (number - 1) % 5])
    Console.WriteLine("{0}号座车票位已售出！", number);
else
{
    seats[(number - 1) / 20, (number - 1) % 5] = true;  //将座位设置成已售状态
    Console.WriteLine("{0}号座位车票成功售出！", number);
}
            Console.Read();
        }
    }
}

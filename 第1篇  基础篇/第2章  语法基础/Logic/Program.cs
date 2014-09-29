using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "按字节提取整型数值";

Console.WriteLine("请输入一个整数：");
int Number = int.Parse(Console.ReadLine());             //从控制台输入一个十进制整数
Console.WriteLine("{0}的十六进制形式为0x{1:X8}", Number, Number);

int NumberHex = Number & 0x000000FF;                    //将数值与0xFF按位与运算
Console.WriteLine("第1个字节为：0x{0:X2}", NumberHex);   //十六进制输出第1个字节
NumberHex = Number >> 8 & 0x000000FF;                   //将数值右移8位与0xFF按位与运算
Console.WriteLine("第2个字节为：0x{0:X2}", NumberHex);   //十六进制输出第2个字节
NumberHex = Number >> 16 & 0x000000FF;                  //将数值右移16位与0xFF按位与运算
Console.WriteLine("第3个字节为：0x{0:X2}", NumberHex);   //十六进制输出第3个字节
NumberHex = Number >> 24 & 0x000000FF;                  //将数值右移24位与0xFF按位与运算
Console.WriteLine("第4个字节为：0x{0:X2}", NumberHex);   //十六进制输出第4个字节

            Console.Readkey();
        }
    }
}

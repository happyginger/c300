using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "从控制台输出整数类型";

sbyte Sbyte = 100;                                      //有符号字节型
byte Byte = 200;                                        //无符号字节型
char Char = '\u0061';                                   //字符型
short Short = 30000;                                    //有符号短整型
ushort UShort = 60000;                                  //无符号短整型
int Int = 2000000000;                                   //有符号整型
uint Uint = 4000000000;                                 //无符号整型
long Long = 9000000000000000000;                        //有符号长整型
ulong Ulong = 18000000000000000000;                     //无符号长整型

Console.WriteLine("有符号字节型\t{0}", Sbyte);
Console.WriteLine("无符号字节型\t{0}", Byte);
Console.WriteLine("字符型\t\t{0}", Char);
Console.WriteLine("有符号短整型\t{0}", Short);
Console.WriteLine("无符号短整型\t{0}", UShort);
Console.WriteLine("有符号整型\t{0}", Int);
Console.WriteLine("无符号整型\t{0}", Uint);
Console.WriteLine("有符号长整型\t{0}", Long);
Console.WriteLine("无符号长整型\t{0}", Ulong);

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "生成学生成绩单";

byte[,] results = new byte[20, 4];              //创建二维数组存放学生成绩
Random random = new Random();                   //随机数发生器
Console.WriteLine("学号\t高数\tC语言\t英语");
for (int id = 0; id < results.GetLength(0); id++)
{
    Console.Write(id);                          //数组的第一列为学生的学号
    for (int i = 1; i < results.GetLength(1); i++)
    {
        results[id, i] = (byte)random.Next(101);//随机生成学生成绩
        Console.Write("\t" + results[id, i]);
    }
    Console.WriteLine();
}

            Console.Read();
        }
    }
}

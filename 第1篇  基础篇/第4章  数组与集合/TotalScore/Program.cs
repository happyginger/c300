using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "求学生总成绩";
//学生姓名列表
string[] students = new string[] { "张三", "李四", "王五", "赵六" };
//创建并初始化二维数组
byte[,] results = new byte[4, 3] { { 32, 43, 65 }, { 62, 52, 62 }, { 54, 27, 87 }, { 86, 95, 24 } };
for (int id = 0; id < 4; id++)
{
    int total = 0;                                      //总成绩
    for (int i = 0; i < 3; i++) total += results[id, i];//求学生总成绩
    Console.WriteLine("{0}的总成绩为{1}", students[id], total);
}
            Console.Read();

        }
    }
}

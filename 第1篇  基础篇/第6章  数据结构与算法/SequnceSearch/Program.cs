using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace SequnceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "查找指定姓名的学生信息";

Console.WriteLine("学生名单如下：");
StudentList students = new StudentList(20);
for (int i = 0; i < 20; i++)
{
    Console.Write(students[i].Name + "\t");
    if ((i + 1) % 5 == 0) Console.WriteLine();
}
string name;
do
{

Console.WriteLine("请输入要查询的学生姓名：");
name = Console.ReadLine();
int i = 0, count = 0;
//顺序查找学生指定学生信息
for (; i < 20; i++)
{
    if (students[i].Name == name)
    {
        Console.WriteLine("学号：{0}\t年级：{1}\t成绩：{2}",
            students[i].Number, students[i].Grade, students[i].Result);
        count++;
    }
}
if (count == 0) Console.WriteLine("无此学生信息！");

} while (name != string.Empty);

            Console.ReadLine();
        }
    }
}

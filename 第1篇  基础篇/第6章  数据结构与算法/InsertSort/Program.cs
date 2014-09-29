using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "对学生表的前十位学生按成绩排序";

StudentList students = new StudentList(20);
Console.WriteLine("排序前的学生信息表：");
for (int i = 0; i < 20; i++)
{
    Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", 
        students[i].Number, students[i].Name, students[i].Result);
}

//遍历索引从1开始的学生信息
for (int i = 1; i < 10; i++)
{
    //如果索引为i的学生成绩大于索引为i-1的学生成绩，则前i+1个学生成绩已经有序
    if (students[i].Result > students[i - 1].Result)
    {
        Student temp = students[i];
        int j = i - 1;
        //将索引为i的学生信息插入到其合适的位置
        for (; j >= 0 && temp.Result > students[j].Result; j--)
        {
            students[j + 1] = students[j];
        }
        students[j + 1] = temp;
    }
}
Console.ReadLine();
Console.Clear();
Console.WriteLine("排序后的学生信息表：");
for (int i = 0; i < 20; i++)
{
    Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].Number, students[i].Name, students[i].Result);
}


            Console.ReadLine();

        }
    }
}

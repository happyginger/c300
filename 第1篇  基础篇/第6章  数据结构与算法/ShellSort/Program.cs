using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将学生按成绩进行希尔排序";

StudentList students = new StudentList(20);
Console.WriteLine("排序前的学生信息表：");
for (int i = 0; i < 20; i++)
{
    Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", 
        students[i].Number, students[i].Name, students[i].Result);
}

for (int increment = 5; increment > 0; increment--)
{
    //遍历索引从increment开始的学生信息
    for (int i = increment; i < 20; i++)
    {
        //如果索引为i的学生成绩大于索引为i-increment的学生成绩
        //则前i/increment+1个学生成绩已经有序
        if (students[i].Result > students[i - increment].Result)
        {
            Student temp = students[i];
            int j = i - increment;
            //将索引为i的学生信息插入到其所在分组中合适的位置
            for (; j >= 0 && temp.Result > students[j].Result; j -= increment)
            {
                students[j + increment] = students[j];
            }
            students[j + increment] = temp;
        }
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

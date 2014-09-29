using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "求学生成绩在前十名的学生";
            StudentList students = new StudentList(20);
            Console.WriteLine("排序前学生信息表：");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].Number, students[i].Name, students[i].Result);
            }
            Console.ReadLine();

Student temp;
int max = 0;
for (int i = 0; i < 10; i++)
{
    max = i;
    for (int j = i + 1; j < 20; j++)
    {
        if (students[j].Result > students[max].Result) max = j;//求成绩最好的学生索引
    }
    //将成绩最好的学生与索引i的学生交换
    temp = students[i];
    students[i] = students[max];
    students[max] = temp;
}

            Console.Clear();
            Console.WriteLine("成绩排在前十名的学生信息表：");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].Number, students[i].Name, students[i].Result);
            }

            Console.ReadLine();
        }
    }
}

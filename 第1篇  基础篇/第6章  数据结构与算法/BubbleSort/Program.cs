using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "对学生表的前十位学生按成绩排序";

            StudentList students = new StudentList(20);
            Console.WriteLine("学生信息表：");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].Number, students[i].Name, students[i].Result);
            }
//正向冒泡排序求最小值
for (int i = 1; i < 20; i++)
{
    //成绩差的上浮
    if (students[i].Result > students[i - 1].Result)
    {
        Student temp = students[i];
        students[i] = students[i - 1];
        students[i - 1] = temp;
    }
}
//逆向冒泡排序求最大值
for (int i = 19; i > 0; i--)
{
    //成绩好的下沉
    if (students[i].Result > students[i - 1].Result)
    {
        Student temp = students[i];
        students[i] = students[i - 1];
        students[i - 1] = temp;
    }
}
            Console.WriteLine("最好成绩为：{0} 最差成绩为：{1}", students[0].Result, students[19].Result);

            Console.ReadLine();
        }
    }
}

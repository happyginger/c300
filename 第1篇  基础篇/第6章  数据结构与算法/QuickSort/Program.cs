using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "求成绩合格的学生";

            StudentList students = new StudentList(20);
            Console.WriteLine("排序前学生信息表：");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].Number, students[i].Name, students[i].Result);
            }

            Console.ReadLine();
            
int low = 0, high = 19;
int result = 60;                                        //合格的成绩
Student temp = students[low];
//第一趟快速排序，将学生按成绩分为大于等于60的和小于60的两部分
while (low < high)
{
    while (low < high && students[high].Result >= result) high--;
    students[low++] = students[high];
    while (low < high && students[low].Result <= result) low++;
    students[high--] = students[low];
}
students[low] = temp;
if (temp.Result < result) low++;

            Console.Clear();
            Console.WriteLine("成绩合格的学生信息表：");
            for (int i = low; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].Number, students[i].Name, students[i].Result);
            }

            Console.ReadLine();
        }
    }
}

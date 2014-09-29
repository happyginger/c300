using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将学生按成绩进行归并排序";

            StudentList students = new StudentList(20);
            Student[] studentsSort = new Student[20];
            Console.WriteLine("排序前的学生信息表：");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].Number, students[i].Name, students[i].Result);
            }
            Console.ReadLine();

            MergeSort(students, studentsSort, 0, 19);

            Console.Clear();
            Console.WriteLine("排序后的学生信息表：");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", studentsSort[i].Number, studentsSort[i].Name, studentsSort[i].Result);
            }

            Console.ReadLine();
        }

//将sts1[begin..end]归并排序为sts2[begin..end]
static void MergeSort(StudentList sts1, Student[] sts2, int begin, int end)
{
    Student[] sts3 = new Student[sts1.Length];
    if (begin == end)
        sts2[begin] = sts1[begin];                      //如果只有一个元素则直接将其归并到sts2中
    else
    {
        int divide = (begin + end) / 2;                 //将表分割成两部分
        MergeSort(sts1, sts3, begin, divide);           //对左半部分进行归并排序并存储到sts3中
        MergeSort(sts1, sts3, divide + 1, end);         //对右半部分进行归并排序并存储到sts3中
        Merge(sts3, sts2, begin, divide, end);          //将左右两部分归并到sts2中
    }
}

        
static void Merge(Student[] sts1, Student[] sts2, int begin, int divide, int end)
{
    int i,j,k,l;
    //将有序的sts1[begin..divide]和sts1[divide+1..end]归并为有序的sts2
    for (i = begin, j = divide + 1, k = begin; i <= divide && j <= end; k++)
    {
        if (sts1[i].Result > sts1[j].Result) sts2[k] = sts1[i++];
        else sts2[k] = sts1[j++];
    }
    //将sts1[begin..divide]剩余部分归并到sts2中
    if (i <= divide) for (l = 0; l <= divide - i; l++) sts2[k + l] = sts1[i + l];
    //将sts1[divide+1..end]剩余部分归并到sts2中
    if (j <= end) for (l = 0; l <= end - j; l++) sts2[k + l] = sts1[j + l];
}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将学生按成绩从低到高排列";
            StudentList students = new StudentList(20);
            Console.WriteLine("排序前学生信息表：");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].Number, students[i].Name, students[i].Result);
            }

            Student temp;

//将建堆后的根结点与索引为i的结点交换
for (int i = 19; i >=1; i--)
{
    CreateHeap(students, i);
    temp = students[0];
    students[0] = students[i];
    students[i] = temp;
}

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("排序后学生信息表：");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", 
                    students[i].Number, students[i].Name, students[i].Result);
            }

            Console.ReadLine();
        }
//建立大根堆
static void CreateHeap(StudentList students, int n)
{
    //从第一个非叶子结点开始遍历
    for (int i = (n -1) / 2; i >= 0; i--)
    {
        int lChild = i * 2 + 1;                 //左孩子索引
        int rChild = i * 2 + 2;                 //右孩子索引
        int max = i;                            //最大值索引
        //将结点i的学生成绩与其左孩子结点的学生成绩比较
        if (students[lChild].Result > students[max].Result) max = lChild;
        //将结点i的学生成绩与其右孩子结点的学生成绩比较
        if (rChild <= n && students[rChild].Result > students[max].Result) max = rChild;
        //将成绩最好的结点调整到索引为i的结点上
        if (max != i)
        {
            Student temp = students[i];
            students[i] = students[max];
            students[max] = temp;
        }
    }
}
    }
}

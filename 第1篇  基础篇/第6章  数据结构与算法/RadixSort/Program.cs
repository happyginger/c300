using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;
using LinkList;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将学生按年级和成绩进行排序";

            StudentLinkList students = new StudentLinkList(20);
            Console.WriteLine("排序前的学生信息表：");
            StudentNode node = students.Head;
            while (node != null)
            {
                Console.WriteLine("姓名：{0}\t年级：{1}\t成绩：{2}", node.Student.Name, node.Student.Grade, node.Student.Result);
                node = node.Next;
            }

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("按成绩排序后的学生信息表：");

StudentQueue[] studentsResult = new StudentQueue[101];  //创建成绩队列列表
node = students.Head;
//将学生按成绩映射到指定索引的队列中
while (node != null)
{
    if (studentsResult[node.Student.Result] == null)
        studentsResult[node.Student.Result] = new StudentQueue();
    studentsResult[node.Student.Result].In(node.Student);
    node = node.Next;
}
StudentNode head = null, rear = null;
//将队列按索引从小到大首尾相连
for (int i = 100; i >= 0; i--)
{
    if (studentsResult[i] != null)
    {
        if (head == null) head = studentsResult[i].Front;//第一个不为空的队列
        else rear.Next = studentsResult[i].Front;
        rear = studentsResult[i].Rear;                  //标记队尾
    }
}

            node = head;
            while (node != null)
            {
                Console.WriteLine("姓名：{0}\t年级：{1}\t成绩：{2}", node.Student.Name, node.Student.Grade, node.Student.Result);
                node = node.Next;
            }

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("按年级排序后的学生信息表：");

StudentQueue[] studentsGrade = new StudentQueue[5];     //创建年级队列列表
node = head;
//将学生按年级映射到指定索引的队列中
while (node != null)
{
    if (studentsGrade[node.Student.Grade] == null)
        studentsGrade[node.Student.Grade] = new StudentQueue();
    studentsGrade[node.Student.Grade].In(node.Student);
    node = node.Next;
}
head = null; rear = null;
//将队列按索引从小到大首尾相连
for (int i = 4; i >= 1; i--)
{
    if (studentsGrade[i] != null)
    {
        if (head == null) head = studentsGrade[i].Front;//第一个不为空的队列
        else rear.Next = studentsGrade[i].Front;
        rear = studentsGrade[i].Rear;                   //标记队尾
    }
}

            node = head;
            while (node != null)
            {
                Console.WriteLine("姓名：{0}\t年级：{1}\t成绩：{2}", node.Student.Name, node.Student.Grade, node.Student.Result);
                node = node.Next;
            }

            Console.ReadLine();
        }

class StudentQueue
{
    public StudentNode Front { get; private set; }      //队头
    public StudentNode Rear { get; private set; }       //队尾
    //进队
    public void In(Student student)
    {
        if (Rear == null)
        {
            Rear = new StudentNode(student, null);
            Front = Rear;
        }
        else
        {
            Rear.Next = new StudentNode(student, null);
            Rear = Rear.Next;
        }
    }
    //出队
    public Student? Out()
    {
        if (Front == null) return null;
        Student student = Front.Student;
        Front = Front.Next;
        if (Front == null) Rear = null;
        return student;
    }
}

    }
}

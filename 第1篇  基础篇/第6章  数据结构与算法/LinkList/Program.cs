using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将两个学生信息表交叉合并";

StudentLinkList list1 = new StudentLinkList(5);         //创建含有5个元素的学生信息链表
StudentNode node1 = list1.Head;                         //学生信息表1的头结点设为当前结点
Console.WriteLine("输出学生信息表1：");
while (node1 != null)
{
    Console.Write(node1.Student.Name + "\t");
    node1 = node1.Next;                                 //将下一结点设置为当前结点
}
Console.WriteLine("\n\n输出学生信息表2：");
StudentLinkList list2 = new StudentLinkList(5);         //创建含有5个元素的学生信息链表
StudentNode node2 = list2.Head;                         //学生信息表2的头结点设为当前结点
while (node2 != null)
{
    Console.Write(node2.Student.Name + "\t");
    node2 = node2.Next;                                 //将下一结点设置为当前结点
}

node1 = list1.Head;                                     //重置表1当前结点
node2 = list2.Head;                                     //重置表2当前结点
//将学生信息表2合并到学生信息表1中
while (node1 != null && node2 != null)
{
    list2.Head = node2.Next;                            //将表2当前结点从表2中删除
    node2.Next = node1.Next;                            //将表1当前结点的后续结点拼接到表2当前结点
    node1.Next = node2;                                 //将表2当前结点作为表1当前结点的下一结点
    node1 = node2.Next;                                 //表1当前结点指向表2当前结点的下一结点
    node2 = list2.Head;                                 //表2当前结点指向表2的头结点
}

Console.WriteLine("\n\n输出合并后的学生信息表1：");
node1 = list1.Head;
while (node1 != null)
{
    Console.Write(node1.Student.Name + "\t");
    node1 = node1.Next;
}

            Console.Read();
        }
    }

    //学生信息链表
public class StudentLinkList
{
    public StudentNode Head { get; set; }               //链表头结点

    public StudentLinkList(int count)
    {
        Head = new StudentNode(new Student(20120000 + count), null);
        //头插法建表
        for (int i = count - 1; i > 0; i--)
        {
            //创建新结点，将原头结点作为新结点下一结点，将新节点作为头结点
            Head = new StudentNode(new Student(20120000 + i), Head);
        }
    }
}

//学生链表结点
public class StudentNode
{
    public Student Student { get; set; }                //学生信息
    public StudentNode Next { get; set; }               //下一结点类实例
    public StudentNode(Student student, StudentNode next)
    {
        this.Student = student;
        this.Next = next;
    }
}
}

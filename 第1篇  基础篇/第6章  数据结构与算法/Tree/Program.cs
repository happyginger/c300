using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将学生信息存储到二叉树中";

StudentTree tree = new StudentTree(10);                 //创建学生信息二叉树
Console.WriteLine("先序遍历：");
tree.PreOrder(tree.Root);
Console.WriteLine("\n中序遍历：");
tree.InOrder(tree.Root);
Console.WriteLine("\n后序遍历：");
tree.PostOrder(tree.Root);

            Console.ReadLine();
        }
    }

    //学生信息二叉树
class StudentTree
{
    public readonly StudentNode Root;                   //树结点
    public static Random R = new Random();
    int count = 0;
    public StudentTree(int count)
    {
        this.count = count;
        this.Root = CreateNode(ref count);
    }
    //创建结点及其子结点
    StudentNode CreateNode(ref int index)
    {
        if (R.Next(count) > index) return null;
        if (--index == 0) return null;
        StudentNode node = new StudentNode(new Student(20120000 + index));
        node.LeftChild = CreateNode(ref index);         //创建左孩子结点
        node.RightChild = CreateNode(ref index);        //创建右孩子结点
        return node;
    }
    //先序遍历
    public void PreOrder(StudentNode node)
    {
        if (node == null) return;
        Console.Write(node.Student.Name + "\t");
        PreOrder(node.LeftChild);
        PreOrder(node.RightChild);
    }
    //中序遍历
    public void InOrder(StudentNode node)
    {
        if (node == null) return;
        InOrder(node.LeftChild);
        Console.Write(node.Student.Name + "\t");
        InOrder(node.RightChild);
    }
    //后序遍历
    public void PostOrder(StudentNode node)
    {
        if (node == null) return;
        PostOrder(node.LeftChild);
        PostOrder(node.RightChild);
        Console.Write(node.Student.Name + "\t");
    }
}
    //学生信息二叉树结点
class StudentNode
{
    public readonly Student Student;                    //学生信息
    public StudentNode LeftChild { get; set; }          //左孩子结点
    public StudentNode RightChild { get; set; }         //右孩子结点
    public StudentNode(Student student)
    {
        this.Student = student;
    }
}

}

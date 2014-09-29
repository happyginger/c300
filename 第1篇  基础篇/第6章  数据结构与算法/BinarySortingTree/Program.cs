using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace BinarySortingTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "查询具有指定成绩的学生信息";
            StudentList students = new StudentList(20);
            
            Console.WriteLine("学生成绩单如下：");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(students[i].Result + "\t");
                if ((i + 1) % 5 == 0) Console.WriteLine();
            }


BTreeNode root = new BTreeNode(students[0]);            //创建二叉排序树根结点
for (int i = 1; i < 20; i++)
{
    CreateBinarySortingTree(root, students[i]);         //根据学生成绩创建二叉排序树
}
int result;
//在二叉排序树上的查找指定成绩学生信息

do
{
Console.WriteLine("请输入要查询的学生的成绩：");
if (!int.TryParse(Console.ReadLine(), out result)) result = -1;
BTreeNode node = root;
bool successful = false;
while (node != null)
{
    if (result > node.Student.Result) node = node.RightChild;//查找右子树
    else if (result < node.Student.Result) node = node.LeftChild;//查找左子树
    else//查找成功
    {
        Console.WriteLine("学号：{0}\t姓名：{1}\t年级：{2}",
            node.Student.Number, node.Student.Name, node.Student.Grade);
        successful = true;
        break;
    }
}
if (!successful) Console.WriteLine("无此学生信息！");//查找失败
                
} while (result != -1);

            Console.ReadLine();
        }



//创建二叉排序树
static void CreateBinarySortingTree(BTreeNode node, Student student)
{
    if (student.Result < node.Student.Result)           //如果成绩比根结点小
    {
        if (node.LeftChild == null)                     //如果左子树为空
            //创建左孩子结点，并将学生信息添加到该孩子结点中
            node.LeftChild = new BTreeNode(student);
        else                                            //如果左子树不为空
            CreateBinarySortingTree(node.LeftChild, student);//将学生信息添加到左子树中
    }
    else if (student.Result > node.Student.Result)      //如果成绩比根结点大
    {
        if (node.RightChild == null)                    //如果右子树为空
            //创建右孩子结点，并将学生信息添加到该孩子结点中
            node.RightChild = new BTreeNode(student);
        else                                            //如果右子树不为空
            CreateBinarySortingTree(node.RightChild, student);//将学生信息添加到右子树中
    }
}
}


    //二叉树结点
class BTreeNode
{
    public Student Student { get; private set; }        //学生信息
    public BTreeNode LeftChild { get; set; }            //左孩子结点
    public BTreeNode RightChild { get; set; }           //右孩子结点
    public BTreeNode(Student student) { this.Student = student; }
}
}

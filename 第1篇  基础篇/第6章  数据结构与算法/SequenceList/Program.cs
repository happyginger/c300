using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceList
{
    class Program
    {
        static void Main(string[] args)
        {
Console.Title = "将学生信息表顺序倒置";

StudentList students = new StudentList(10);             //创建含有10个元素的学生信息表
Console.WriteLine("按顺序输出学生姓名：");
for (int i = 0; i < 10; i++) Console.Write(students[i].Name + "\t");
//将学生表前面的元素与后面的元素互换
for (int i = 0; i < 5; i++)
{
    Student temp = students[i];
    students[i] = students[9 - i];
    students[9 - i] = temp;
}
Console.WriteLine("输出学生信息表倒置后的学生姓名：");
for (int i = 0; i < 10; i++) Console.Write(students[i].Name + "\t");

            Console.Read();
        }
    }

    //学生信息表类
public class StudentList
{
    private Student[] Students;                         //学生信息顺序表
    //检索学生信息表
    public Student this[int index]
    {
        get { return Students[index]; }
        set { Students[index] = value; }
    }
    public StudentList(int count)
    {
        this.Students = new Student[count];             //创建学生信息表
        //为学生信息表添加学生信息
        for (int i = 0; i < count; i++)
        {
            this.Students[i] = new Student(20120001 + i);
        }
    }
    public int Length { get { return Students.Length; } }//顺序表长度
}

//学生信息结构体
public struct Student
{
    static readonly string[] LastNames =                //姓列表
        new string[] { "赵", "钱", "孙", "李", "周", "吴", "郑", "王" };
    static readonly string[] FirstNames =               //名列表
        new string[] { "一", "二", "三", "四", "五", "六", "七", "八" };
    static readonly Random R = new Random();
    public readonly string Name;                        //姓名
    public readonly int Number;                         //学号
    public readonly int Grade;                          //年级
    public readonly int Result;                         //成绩
    public Student(int number)
    {
        this.Name = LastNames[R.Next(LastNames.Length)] //随机生成姓
            + FirstNames[R.Next(FirstNames.Length)];    //随机生成名
        this.Number = number;
        this.Grade = R.Next(1,5);                       //随机生成年级
        this.Result = R.Next(101);                      //随机生成分数
    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2} {3}", Name, Number, Grade, Result);
    }
}
}

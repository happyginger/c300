using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "输出学生表中男生的信息";

StudentTable table = new StudentTable();
table.Display(Display);                                 //显示表中所有男生信息


            Console.ReadLine();
        }
//显示男生信息
static void Display(Student student)
{
    if (student.Sex == "男")
        Console.WriteLine("学号：{0}\t姓名:{1}\t性别：{2}",
            student.Number, student.Name, student.Sex);
}

    }
delegate void DisplayStudent(Student student);          //显示学生信息委托
//学生信息表类
class StudentTable
{
    Student[] students;                                 //学生信息列表
    public StudentTable()
    {
        students = new Student[8];                      //创建学生信息表
        students[0] = new Student() { Number = 20120001, Name = "张三", Sex = "男" };
        students[1] = new Student() { Number = 20120002, Name = "李四", Sex = "女" };
        students[2] = new Student() { Number = 20120003, Name = "王五", Sex = "男" };
        students[3] = new Student() { Number = 20120004, Name = "赵六", Sex = "女" };
        students[4] = new Student() { Number = 20120005, Name = "钱七", Sex = "男" };
        students[5] = new Student() { Number = 20120006, Name = "孙三", Sex = "女" };
    }
    public void Display(DisplayStudent display)         //显示学生信息
    {
        foreach (Student student in students) display(student);
    }
}
//学生信息结构体
struct Student
{
    public int Number;                                  //学号
    public string Name;                                 //姓名
    public string Sex;                                  //性别
}
}

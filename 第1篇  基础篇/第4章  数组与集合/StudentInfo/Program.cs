using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "生成学生信息表";

ArrayList students = new ArrayList();                       //学生信息表
students.Add(new Student("张三", 20, "男", 20120001));     //添加学生"张三"的信息
students.Add(new Student("李四", 19, "女", 20120002));     //添加学生"李四"的信息
students.Add(new Student("王五", 18, "男", 20120003));     //添加学生"王五"的信息
students.Add(new Student("赵六", 21, "女", 20120004));     //添加学生"赵六"的信息
//遍历学生信息表，输出学生信息
foreach (Student s in students)
{
    Console.WriteLine("{0}\t{1}岁\t{2}生\t{3}号", s.Name, s.Age, s.Sex, s.ID);
}

            Console.ReadLine();
        }

//学生信息
struct Student
{
    public string Name;                                 //姓名
    public byte Age;                                    //年龄
    public string Sex;                                  //性别
    public int ID;                                      //学号
    public Student(string name, byte age, string sex, int id)
    {
        Name = name;
        Age = age;
        Sex = sex;
        ID = id;
    }
}
    }
}

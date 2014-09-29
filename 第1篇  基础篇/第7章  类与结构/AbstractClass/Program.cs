using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "图书馆管理学生借书权限";

Student Undergraduate = new Undergraduate();            //创建本科生实例
Console.WriteLine("本科生可以借{0}本书", Undergraduate.Authority());
Student Postgraduate = new Postgraduate();              //创建本科生实例
Console.WriteLine("硕士生可以借{0}本书", Postgraduate.Authority());
Student Doctor = new Doctor();                          //创建本科生实例
Console.WriteLine("博士生可以借{0}本书", Doctor.Authority());

            Console.ReadLine();
        }
    }

//抽象学生类
abstract class Student
{
    public abstract int Authority();                    //抽象获取权限方法
}
//本科生
class Undergraduate : Student
{
    public override int Authority() { return 5; }       //重写获取权限方法
}
//硕士生
class Postgraduate : Student
{
    public override int Authority() { return 10; }       //重写获取权限方法
}
//博士生
class Doctor : Student
{
    public override int Authority() { return 15; }       //重写获取权限方法
}
}

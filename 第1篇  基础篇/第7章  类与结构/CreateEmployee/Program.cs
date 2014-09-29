using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "创建员工信息表";

Employee[] Employees = new Employee[3];                 //创建员工信息表
Employees[0] = new Employee(20120001);                  //实例化员工1
Employees[1] = new Employee(20120002, "李四");            //实例化员工2
Employees[2] = new Employee(name:"王五",number:20120003);//实例化员工3
//输出员工信息
foreach (Employee employee in Employees)
{
    Console.WriteLine(employee.GetInfo());
}

            Console.ReadLine();
        }
    }
//定义员工类型
internal class Employee
{
    private int number;                                 //员工编号私有成员变量
    public int Number { get { return number; } }        //员工编号公有属性
    public string Name { get; private set; }            //员工姓名公有属性
    public Employee(int number, string name = "张三")    //构造函数
    {
        this.number = number;                           //为编号赋值
        this.Name = name;                               //为姓名赋值
    }
    //获取员工信息
    public string GetInfo() 
    { 
        return string.Format("编号：{0} 姓名：{1}", this.number, this.Name); 
    }
}
}

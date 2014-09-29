using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReloadFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "计算不同级别员工工资";

Employee zs = new Employee("张三");
Employee ls = new Employee("李四");
Employee ww = new Employee("王五");
zs.Salary(1000);
ls.Salary(1200, 500);
ww.Salary(2000, 1000, 2000);

            Console.ReadLine();
        }
    }
//员工类
class Employee
{
    public string Name { get; private set; }            //员工姓名
    public Employee(string name)
    {
        this.Name = name;
    }
    public void Salary(int basePay)                     //给员工发薪水
    {
        Console.WriteLine("{0}的薪水为：基本工资{1}", Name, basePay);
    }
    public void Salary(int basePay, int housingAllowance)//给员工发薪水
    {
        Console.WriteLine("{0}的薪水为：基本工资{1}+住房津贴{2}={3}",
            Name, basePay, housingAllowance, basePay + housingAllowance);
    }
    public void Salary(int basePay, int housingAllowance, int moneyAward)//给员工发薪水
    {
        Console.WriteLine("{0}的薪水为：基本工资{1}+住房津贴{2}+奖金{3}={4}",
            Name, basePay, housingAllowance, moneyAward,
            basePay + housingAllowance + moneyAward);
    }
}
}

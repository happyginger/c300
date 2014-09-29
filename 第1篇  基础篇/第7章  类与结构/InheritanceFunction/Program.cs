using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "输出不同员工的工作内容";

Employee Researcher = new Researcher();                 //创建研究员实例
Researcher.Work();
Employee Engineer = new Engineer();                     //创建工程师实例
Engineer.Work();
Employee Manager = new Manager();                       //创建经理实例
Manager.Work();

            Console.ReadLine();
        }
    }

//员工
class Employee
{
    protected string position;                          //职位
    protected string something;                         //事情
    public void Work()                                  //输出职位所做的事情
    {
        Console.WriteLine("{0}的工作是{1}",position, something);
    }
}
//研究员
class Researcher : Employee
{
    public Researcher()
    {
        this.position = "研究员";
        this.something = "读论文，提想法。";
    }
}
//工程师
class Engineer : Employee
{
    public Engineer()
    {
        this.position = "工程师";
        this.something = "按照流程开发产品。";
    }
}
//经理
class Manager : Employee
{
    public Manager()
    {
        this.position = "经理";
        this.something = "全盘掌控一个产品，广泛了解一个行业。";
    }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "计算两个数的加减乘除";

Console.WriteLine("请输入数 a：");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("请输入数 b：");
double b = double.Parse(Console.ReadLine());
IArithmetic Add = new Add();                             //创建加法类
Console.WriteLine("{0} ＋ {1} = {2:N3}", a, b, Add.Operation(a, b));//两数相加
IArithmetic Subtract = new Subtract();                   //创建减法类
Console.WriteLine("{0} － {1} = {2:N3}", a, b, Subtract.Operation(a, b));//两数相减
IArithmetic Multiply = new Multiply();                   //创建乘法类
Console.WriteLine("{0} × {1} = {2:N6}", a, b, Multiply.Operation(a, b));//两数相乘
IArithmetic Divide = new Divide();                       //创建除法类
Console.WriteLine("{0} ÷ {1} = {2:N6}", a, b, Divide.Operation(a, b));//两数相除

            Console.ReadLine();
        }
    }
//算术运算接口
interface IArithmetic
{
    double Operation(double a, double b);                       //两个数运算接口方法
}
//加法运算类
class Add : IArithmetic
{
    public double Operation(double a, double b) { return a + b; }//实现接口方法
}
//减法运算类
class Subtract : IArithmetic
{
    public double Operation(double a, double b) { return a - b; }//实现接口方法
}
//乘法运算类
class Multiply : IArithmetic
{
    public double Operation(double a, double b) { return a * b; }//实现接口方法
}
//除法运算类
class Divide : IArithmetic
{
    public double Operation(double a, double b) { return a / b; }//实现接口方法
}
}

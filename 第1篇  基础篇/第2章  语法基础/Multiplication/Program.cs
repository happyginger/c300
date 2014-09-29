using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "求解多个数的乘法运算";

Console.WriteLine("请输入第一个数：");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("请输入第二个数：");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("请输入第三个数：");
int number3 = int.Parse(Console.ReadLine());
Program p = new Program();
int result;                                             //存储三个数相乘的结果
p.GetMultResult(out result, number1, number2, number3);
Console.WriteLine("{0} * {1} * {2} = {3}", number1, number2, number3, result);

            Console.ReadLine();
        }

/// 求多个整数的乘积
/// <param name="result">多个整数的乘积</param>
/// <param name="numbers">需要求乘积的整数集合</param>
public void GetMultResult(out int result, params int[] numbers)
{
    result = 1;                                         //初始值为1
    foreach (int number in numbers) result *= number;   //计算多个整数乘积
}


    }
}

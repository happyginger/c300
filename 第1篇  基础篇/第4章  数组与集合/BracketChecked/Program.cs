using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BracketChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "括号匹配检测";
            do
            {
Console.Clear();

Console.WriteLine("请输入带括号的表达式：");
string expression = Console.ReadLine();
if (expression == string.Empty) continue;

Stack<char> brackets = new Stack<char>();
foreach (char bracket in expression)
{
    if (bracket == '(' || bracket == '[' || bracket == '{')
    {
        brackets.Push(bracket);     //括号进入栈
    }
    else if (bracket == ')' && brackets.Pop() != '('
        || bracket == ']' && brackets.Pop() != '['
        || bracket == '}' && brackets.Pop() != '{')
    {
        Console.WriteLine("表达式括号格式错误！");
        continue;
    }
}
if (brackets.Count == 0) Console.WriteLine("表达式括号格式正确！");
else Console.WriteLine("表达式括号格式错误！");
            } while (Console.ReadLine() != "exit");
        }
    }
}

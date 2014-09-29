using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "将十进制数转换为八进制数";

Console.WriteLine("请输入一个十进制正整数：");
int number = int.Parse(Console.ReadLine());

NumberStack stack = new NumberStack();                  //创建数字链栈
while (number > 0)
{
    stack.Push(number % 8);                             //8进制低位先进栈
    number /= 8;
}
Console.WriteLine("转换为八进制数为：");
int? bit = stack.Pop();                                 //8进行高位先出栈
while (bit != null)
{
    Console.Write(bit);
    bit = stack.Pop();                                  //8进行高位先出栈
}

            Console.Read();
        }
    }

    //数据链栈
class NumberStack
{
    private NumberNode top;                             //栈顶
    //进栈
    public void Push(int number)
    {
        if (top == null) top = new NumberNode(number, null);
        else top = new NumberNode(number, top);
    }
    //出栈
    public int? Pop()
    {
        if (this.top == null) return null;
        else
        {
            int number =  top.Number;
            top = top.Next;
            return number;
        }
    }
}

    //数据结点
class NumberNode
{
    public int Number { get; set; }                     //数据
    public NumberNode Next { get; set; }                //下一结点
    public NumberNode(int number, NumberNode next)
    {
        this.Number = number;
        this.Next = next;
    }
}
}

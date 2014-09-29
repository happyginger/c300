using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "判断一个字符串是否为回文";

Console.WriteLine("请输入字符串：");
string str = Console.ReadLine();
    do
    {

CharStack stack = new CharStack();                      //创建字符栈
CharQueue queue = new CharQueue();
foreach (var Char in str)
{
    stack.Push(Char);                                   //字符进栈
    queue.In(Char);                                     //字符进队
}
char? charStack, charQueue;
do
{
    charQueue = queue.Out();                            //字符出队
    charStack = stack.Pop();                            //字符出栈
    if (charStack != charQueue) break;
} while (charStack != null && charQueue != null);

if (charStack != null || charStack != null)
    Console.WriteLine("“{0}”不是回文", str);
else
    Console.WriteLine("“{0}”是回文", str);


    Console.WriteLine("请输入字符串：");
    str = Console.ReadLine();
    } while (str != string.Empty);



            Console.ReadLine();
        }
    }

//字符链栈
class CharStack
{
    CharNode top;   //栈顶
    //进栈
    public void Push(char Char)
    {
        if (top == null) top = new CharNode(Char, null);
        else top = new CharNode(Char, top);
    }
    //出栈
    public char? Pop()
    {
        if (this.top == null) return null;
        else
        {
            char Char = top.Char;
            top = top.Next;
            return Char;
        }
    }
}

//字符链队
class CharQueue
{
    CharNode front;                                     //队头
    CharNode rear;                                      //队尾
    //进队
    public void In(char Char)
    {
        if (rear == null)
        {
            rear = new CharNode(Char, null);
            front = rear;
        }
        else
        {
            rear.Next = new CharNode(Char, null);
            rear = rear.Next;
        }
    }
    //出队
    public char? Out()
    {
        if (front == null) return null;
        char Char = front.Char;
        front = front.Next;
        if (front == null) rear = null;
        return Char;
    }
}

//字符结点
class CharNode
{
    public char Char { get; set; }                      //字符
    public CharNode Next { get; set; }                  //下一结点
    public CharNode(char Char, CharNode next)
    {
        this.Char = Char;
        this.Next = next;
    }
}
}

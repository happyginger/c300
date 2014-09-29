using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace PartnerMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "模拟舞伴配对问题";
//进入舞厅的男士列表
string[] gentlemen = new string[] { "郑一", "张三", "王五", "周七", "钱九" };
//进入舞厅的女士列表
string[] ladies = new string[] { "胡二", "李四", "赵六"};
Queue<string> waitingGentlemen = new Queue<string>();   //男士等待队列
Queue<string> waitingLadies = new Queue<string>();      //女士等待队列
Queue<string> dancingGentlemen = new Queue<string>();   //男士跳舞队列
Queue<string> dancingLadies = new Queue<string>();      //女士跳舞队列
//男士进入等待队列
foreach (string gentleman in gentlemen) waitingGentlemen.Enqueue(gentleman);
//女士进入等待队列
foreach (string lady in ladies)waitingLadies.Enqueue(lady);

int turns = 1;      //舞曲场次
do
{
    Console.Clear();
    Console.WriteLine("第 {0} 场舞曲开始：", turns++);
    while (waitingGentlemen.Count > 0 && waitingLadies.Count > 0)
    {
        string gentleman = waitingGentlemen.Dequeue();  //从等待队列头部出来一位男士
        string lady = waitingLadies.Dequeue();          //从等待队列头部出来一位女士
        Console.WriteLine("{0} 先生与 {1} 女士配成舞伴开始跳舞！", gentleman, lady);
        dancingGentlemen.Enqueue(gentleman);            //男士进入跳舞队列
        dancingLadies.Enqueue(lady);                    //女士进入跳舞队列
    }
    //输出剩下没有舞伴的先生和女士
    foreach (var gentleman in waitingGentlemen) Console.WriteLine("{0} 先生等待舞伴！", gentleman);
    foreach (var lady in waitingLadies) Console.WriteLine("{0} 女士等待舞伴！", lady);
    Console.WriteLine("舞曲停止：");
    while (dancingGentlemen.Count > 0 && dancingLadies.Count > 0)
    {
        string gentleman = dancingGentlemen.Dequeue();  //从跳舞队列中出来一位男士
        string lady = dancingLadies.Dequeue();          //从跳舞队列中出来一位女士
        Console.WriteLine("{0} 先生进入男士等待队列！", gentleman);
        Console.WriteLine("{0} 女士进入女士等待队列！", lady);
        waitingGentlemen.Enqueue(gentleman);            //男士进入等待队列末尾
        waitingLadies.Enqueue(lady);                    //女士进入等待队列末尾
    }
} while (Console.ReadLine() != "exit") ;

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;
using LinkList;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "按学生成绩构造哈希表";
            StudentList students = new StudentList(20);

            Console.WriteLine("学生成绩单如下：");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(students[i].Result + "\t");
                if ((i + 1) % 5 == 0) Console.WriteLine();
            }

            //创建哈希表
StudentNode[] hashTable = new StudentNode[5];
for (int i = 0; i < 20; i++)
{
    int index = students[i].Result % 5;                 //计算哈希地址
    if (hashTable[index] == null) hashTable[index] = new StudentNode(students[i], null);
    else hashTable[index] = new StudentNode(students[i], hashTable[index]);
}

int result;
do
{
Console.WriteLine("请输入要查询的学生的成绩：");
if (!int.TryParse(Console.ReadLine(), out result)) break;
bool successful = false;                                //标记查找是否成功
StudentNode node = hashTable[result % 5];               //计算哈希地址
while (node != null)
{
    if (node.Student.Result == result)                  //查找成功
    {
        Console.WriteLine("学号：{0}\t姓名：{1}\t年级：{2}",
            node.Student.Number, node.Student.Name, node.Student.Grade);
        successful = true;
    }
    node = node.Next;
}
if (!successful) Console.WriteLine("无此学生信息！");      //查找失败
} while (result != -1);


            Console.ReadLine();
        }

        
    }
}

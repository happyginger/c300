using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SequenceList;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "查找指定学号的学生信息";

            Console.WriteLine("学生学号列表如下：");
StudentList students = new StudentList(20);
for (int i = 0; i < 20; i++)
{
    Console.Write(students[i].Number + "\t");
    if ((i + 1) % 5 == 0) Console.WriteLine();
}
int number;
do
{
Console.WriteLine("请输入要查询的学生学号：");
if (!int.TryParse(Console.ReadLine(), out number)) number = 0;
int middle = 0;                                     //用于查找的对象索引
int low = 0;                                        //查找区域索引下限
int high = 19;                                      //查找区域索引上限
int flag = -1;                      //用于标记查找成功时的索引，如果查找失败则为-1
//折半查找学生指定学生信息
while(low <= high)
{
    middle = (low + high) / 2;
    if (number > students[middle].Number) low = middle + 1;//下一次在右半区域中查找
    else if (number < students[middle].Number) high = middle - 1;//下一次在左半区域中查找
    else
    {
        flag = middle;//查找成功，将记录索引存入flag中
        break;          //跳出查找循环
    }
}
if (flag > 0)//查找成功
    Console.WriteLine("姓名：{0}\t年级：{1}\t成绩：{2}",
        students[flag].Name, students[flag].Grade, students[flag].Result);
else Console.WriteLine("无此学生信息！");//查找失败
} while (number != 0);

            Console.ReadLine();
        }
    }
}

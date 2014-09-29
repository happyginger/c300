using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BinaryCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "二进制比较文件";

Console.WriteLine("请输入原始文件名：");
FileStream fileOrigin = File.OpenRead(Console.ReadLine());
Console.WriteLine("请输入目标件名：");
FileStream fileDestination = File.OpenRead(Console.ReadLine());

BinaryReader readerOrigin = new BinaryReader(fileOrigin);//创建原始文件二进制读取器
BinaryReader readerDestination = new BinaryReader(fileDestination);//创建目标文件二进制读取器
int maxLength = Math.Max((int)fileOrigin.Length,(int)fileDestination.Length);
int minLength = Math.Min((int)fileOrigin.Length,(int)fileDestination.Length);
int countEqual = 0;                                     //统计相同字节数量
for (int i = 0; i < minLength; i++)
{
    if (readerOrigin.ReadByte() == readerDestination.ReadByte()) countEqual++;//判断字节是否相同
}
Console.WriteLine("目标文件与原始文件相同字节数为{0}", countEqual);
Console.WriteLine("目标文件与原始文件相似度为{0:00.00%}", (float)countEqual / maxLength);
readerOrigin.Close();
readerDestination.Close();
fileOrigin.Close();
fileDestination.Close();


            Console.ReadLine();
        }
    }
}

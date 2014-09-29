using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "分割文件";

string fileName = Directory.GetCurrentDirectory() + "\\300 classic examples.txt";
StreamWriter writer = File.CreateText(fileName);        //创建文本文件写入流类实例
for (int i = 0; i < 100; i++) writer.Write("300 classic examples ");//将文本写入文件
writer.Close();                                         //关闭写入流

FileStream file = new FileStream(fileName, FileMode.Open);//创建文件流类型
Console.WriteLine("文件{0}的长度为{1}字节", file.Name, file.Length);
Console.WriteLine("请输入需要分割的文件长度：");
int subLength = int.Parse(Console.ReadLine());          //分割后子文件的长度
byte[] buffer = new byte[subLength];
Console.WriteLine("分割后的文件及路径：");
int subCount = (int)(file.Length + subLength - 1) / subLength;//分割后子文件的数量
for (int i = 0; i < subCount; i++)
{
    int readLength = file.Read(buffer, 0, subLength);   //读取的字节数
    string subName = file.Name + "." + i + ".segment";
    FileStream subFile = File.Create(subName);          //创建子文件
    subFile.Write(buffer, 0, readLength);               //写入子文件
    subFile.Close();
    Console.WriteLine("文件{0}\t长度{1}字节", subName, readLength);
}
file.Close();

            Console.ReadLine();
        }
    }
}

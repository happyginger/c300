using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Rename
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "批量重命名文件";

Random random = new Random();
string path = Directory.GetCurrentDirectory();          //获取当前路径
//创建10个随机命名的文件
for (int i = 0; i < 10; i++)
{
    File.CreateText(path + "\\" + random.Next(int.MaxValue) + ".txt").Close();
}
DirectoryInfo directoryInfo = new DirectoryInfo(path);  //创建当前目录信息类实例
Console.WriteLine("当前目录下的文本文件有：");
foreach (FileInfo file in directoryInfo.GetFiles("*.txt")) Console.WriteLine(file.Name);
            
Console.ReadLine();
Console.Clear();

Console.WriteLine("对当前目录下的文本文件重命名:");
foreach (FileInfo file in directoryInfo.GetFiles("*.txt"))
{
    string newName = random.Next(int.MaxValue).ToString();
    Console.WriteLine("将{0}重命名为{1}", file.Name, newName + ".txt");
    File.Move(file.Name, newName + ".txt");             //对文件进行重命名
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("重新输出当前目录下的文本文件：");
foreach (FileInfo file in directoryInfo.GetFiles("*.txt")) Console.WriteLine(file.Name);

foreach (FileInfo file in directoryInfo.GetFiles("*.txt")) file.Delete();

            Console.ReadLine();
        }
    }
}

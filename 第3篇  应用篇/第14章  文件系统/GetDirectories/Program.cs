using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GetDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "输出子文件夹路径";

string path = @"V:\300ClassicExamples\Foundation"; //文件夹路径
DisplayDirectories(path);                               //输出文件夹的所有子文件夹
            Console.ReadLine();
        }

static void DisplayDirectories(string path)
{
    DirectoryInfo directoryInfo = new DirectoryInfo(path);//创建文件夹信息类实例
    Console.WriteLine(directoryInfo.FullName);          //输出文件夹信息
    foreach (DirectoryInfo DI in directoryInfo.GetDirectories())//遍历指定文件夹下所有的文件夹
    {
        DisplayDirectories(DI.FullName);                //输出子文件夹信息
    }
}
    }
}

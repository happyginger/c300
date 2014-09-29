using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace FileStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "统计文件数目";

string path = @"V:\300ClassicExamples\Foundation";      //指定文件夹
Console.WriteLine("路径{0}下的文件数目为：{1}", path, GetFileCount(path));

            Console.ReadLine();
        }
//统计path路径下的文件数目
static int GetFileCount(string path)
{
    int count = 0;                                      //文件数目
    DirectoryInfo directoryInfo = new DirectoryInfo(path);//路径信息
    count += directoryInfo.GetFiles().Length;           //获取路径下的文件数目
    foreach (var item in directoryInfo.GetDirectories())//获取路径下的子目录
    {
        count += GetFileCount(item.FullName);           //获取子目录中的文件数目
    }
    return count;                                       //文件总数
}
    }
}

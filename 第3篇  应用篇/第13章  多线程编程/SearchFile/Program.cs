using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace SearchFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "查找本地文件";

Search(@"V:\300ClassicExamples");           //搜索V:\300ClassicExamples下的.sln后缀的文件

            Console.ReadLine();
        }

static void Search(object path)                         //搜索指定路径线程函数
{
    DirectoryInfo DI = new DirectoryInfo(path.ToString());//创建目录信息
    FileInfo[] FIs = DI.GetFiles("*.sln");              //获取.sln后缀的文件
    DirectoryInfo[] DIs = DI.GetDirectories();          //获取子目录
    foreach (var item in FIs) Console.WriteLine(item.FullName);//输出.sln后缀的文件
    foreach (var item in DIs)                           //创建线程，搜索子目录
    {
        Thread thread = new Thread(new ParameterizedThreadStart(Search));
        thread.Start(item.FullName);
    }
}
    }
}

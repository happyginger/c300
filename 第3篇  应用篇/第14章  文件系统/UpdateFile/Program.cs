using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UpdateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "开启文件隐藏属性";

string fileName = "test.txt";                           //文件名
if (!File.Exists(fileName)) File.Create(fileName);      //创建一个文本文件

//判断文件夹是否已经具有隐藏属性
if ((File.GetAttributes(fileName) & FileAttributes.Hidden) != FileAttributes.Hidden)
{
    File.SetAttributes(fileName, FileAttributes.Hidden);//将文件隐藏属性开启
}

            Console.ReadLine();
        }
    }
}

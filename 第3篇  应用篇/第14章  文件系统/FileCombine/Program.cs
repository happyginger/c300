using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileCombine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "拼接文件";

string fileName = Directory.GetCurrentDirectory() + "\\300 classic examples.txt";
FileStream file = File.Create(fileName);                //创建主文件

int subIndex = 0;                                       //子文件索引
while (File.Exists(file.Name + "." + subIndex + ".segment"))
{
    //打开子文件流
    FileStream subFile = new FileStream(file.Name + "." + subIndex + ".segment", FileMode.Open);
    byte[] buffer = new byte[subFile.Length];           //子文件缓存
    int readLength = subFile.Read(buffer, 0, buffer.Length);//读取子文件
    file.Write(buffer, 0, readLength);                  //将子文件写入主文件中
    subFile.Close();
    subIndex++;
}
file.Close();                                           //关闭主文件流

StreamReader reader = new StreamReader(fileName);
Console.WriteLine(reader.ReadToEnd());                  //输出拼接后的文件
reader.Close();

            Console.ReadLine();
        }
    }
}

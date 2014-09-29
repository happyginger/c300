using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.IO.Compression;

namespace FileCompress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "压缩文件";

StreamReader fileOrigin = File.OpenText("300 classic examples.txt");//打开原始文件
string data = fileOrigin.ReadToEnd();                   //读取原始文件
Console.WriteLine("原始文件大小为{0}字节", data.Length);

FileStream fileCompress = new FileStream("300 classic examples.gzip", FileMode.Create, FileAccess.Write);                                      //创建压缩文件
//创建压缩和解压缩流对象
GZipStream compressionStream = new GZipStream(fileCompress, CompressionMode.Compress);
StreamWriter writer = new StreamWriter(compressionStream);//创建写入压缩流对象
writer.Write(data);                                     //将文件内容写入压缩流中
Console.WriteLine("压缩后文件大小为{0}字节", fileCompress.Length);

writer.Close();
compressionStream.Close();
fileCompress.Close();

            Console.ReadLine();
        }
    }
}

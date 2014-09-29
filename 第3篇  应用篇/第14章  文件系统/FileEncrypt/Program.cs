using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace FileEncrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "文件加密";



FileStream file = File.OpenRead("300 classic examples.txt");//以只读方式打开文件
byte[] fileArray = new byte[file.Length];               //缓存文件
file.Read(fileArray, 0, fileArray.Length);              //读取文件内容
file.Close();

DESCryptoServiceProvider des = new DESCryptoServiceProvider();//DES加密算法服务对象
des.GenerateKey();                                      //生成DES加密密钥
des.GenerateIV();                                       //生成DES加密初始化向量
Console.WriteLine("DES加密密钥为：");
foreach (var item in des.Key) Console.Write(string.Format("{0:X2}", item));
Console.WriteLine("\nDES加密初始化向量为：");
foreach (var item in des.IV) Console.Write(string.Format("{0:X2}", item));
FileStream fileKey = File.Create("Key");                //将Key存储到文件中
fileKey.Write(des.Key, 0, des.Key.Length);
fileKey.Close();
FileStream fileIV = File.Create("IV");                  //将IV存储到文件中
fileIV.Write(des.IV, 0, des.IV.Length);
fileIV.Close();

MemoryStream memoryStream = new MemoryStream();         //创建内存流对象
//创建加密流对象
CryptoStream cryptoStream = new CryptoStream(memoryStream, des.CreateEncryptor(), CryptoStreamMode.Write);
cryptoStream.Write(fileArray, 0, fileArray.Length);     //将文件内容加密后的文件写入内存流中
cryptoStream.FlushFinalBlock();
FileStream fileEncrypt = File.Create("300 classic examples.encrypt");//加密后的文件
//将加密的文件内容写入到文件中
foreach (byte value in memoryStream.ToArray()) fileEncrypt.WriteByte(value);
Console.WriteLine("\n文件已加密!\n密文保存到文件300 classic examples.encrypt中");
fileEncrypt.Close();
cryptoStream.Close();
memoryStream.Close();

            Console.ReadLine();
        }
    }
}

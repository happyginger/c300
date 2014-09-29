using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace FileDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "解密文件";

DESCryptoServiceProvider des = new DESCryptoServiceProvider();//DES加解密算法服务对象
FileStream fileEncrypt = File.OpenRead("300 classic examples.encrypt");//打开加密的文件
byte[] fileArray = new byte[fileEncrypt.Length];
fileEncrypt.Read(fileArray, 0, fileArray.Length);
fileEncrypt.Close();

FileStream fileKey = File.OpenRead("Key");              //打开密钥文件
byte[] key = new byte[fileKey.Length];                  //密钥
fileKey.Read(key, 0, key.Length);                       //读取密钥
fileKey.Close();
des.Key = key;
FileStream fileIV = File.OpenRead("IV");                //打开初始化向量文件
byte[] IV = new byte[fileIV.Length];                    //初始化向量
fileIV.Read(IV, 0, IV.Length);                          //读取初始化向量
fileIV.Close();
des.IV = IV;

MemoryStream memoryStream = new MemoryStream();         //创建内存流对象
CryptoStream cryptoStream = new CryptoStream(memoryStream, des.CreateDecryptor(), CryptoStreamMode.Write);              //创建解密流对象
cryptoStream.Write(fileArray, 0, fileArray.Length);     //将解密后的文件内容写入内存流中
cryptoStream.FlushFinalBlock();

FileStream file = File.Create("300 classic examples.txt");//创建原文件
//将解密的文件内容写入到文件中
foreach (byte value in memoryStream.ToArray()) file.WriteByte(value);
file.Close();
cryptoStream.Close();
memoryStream.Close();
            
            Console.ReadLine();
        }
    }
}

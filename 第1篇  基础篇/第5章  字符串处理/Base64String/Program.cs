using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base64String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "对古诗进行Base64编码";

Console.WriteLine("《鸟鸣涧》");
string poetry = "人闲桂花落，夜静春山空。月出惊山鸟，时鸣春涧中。";
Console.WriteLine(poetry);

byte[] bytePoetry = Encoding.Default.GetBytes(poetry);  //将古诗转换成字节数组
string base64Poetry = Convert.ToBase64String(bytePoetry);//将字符数组进行Base64编码

Console.WriteLine("古诗的Base64编码为：");
Console.WriteLine(base64Poetry);

            Console.ReadLine();
        }
    }
}

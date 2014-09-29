using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOperator;
using System.IO;

namespace OpenWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "读取Word文档中的表格";

WordOperator word = new WordOperator();
word.OpenWord(Directory.GetCurrentDirectory() + "\\第02章  语法基础.doc");//打开Word文档
Console.WriteLine(word.ReadTable());                    //读取Word文档中的表格
word.QuitWord();

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Office.Interop.Word;
using OfficeOperator;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace CreateWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "创建Word文档";

WordOperator word = new WordOperator();
word.CreateWord();                                      //创建Word文档

word.SetPageHeader("C#经典实例300个");                   //添加页眉
word.SetPageFooter("第17章  访问office");                //添加页脚

word.InsertPageNumber(true);                            //添加页码

word.InsertText("Word文档创建成功！", 16, WdColor.wdColorBlack, 1, WdParagraphAlignment.wdAlignParagraphCenter, "宋体");   //添加文字
word.NewLine();                                         //换行
word.InsertText("Word文档创建成功！", 18, WdColor.wdColorRed, 0, WdParagraphAlignment.wdAlignParagraphDistribute, "黑体");//添加文字

word.InsertPicture(Directory.GetCurrentDirectory() + "\\魔方.jpg", 100, 75);//添加图片

word.NewPage();                                         //换页

SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student_info", 
    "Data Source=.\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
DataSet dataSet = new DataSet();
adapter.Fill(dataSet);                                  //填充数据集
word.InsertTable(dataSet);                              //插入表格

word.SaveWord(Directory.GetCurrentDirectory() + "\\测试文档.doc");//保存Word文档

Console.ReadLine();

word.QuitWord();                                        //退出Word应用程序

            Console.WriteLine("Word文档创建成功！");

        }
    }
}

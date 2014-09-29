using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOperator;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace OpenExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "读取Excel表格";

ExcelOperator excel = new ExcelOperator();              //创建Excel操作对象
excel.OpenExcel(Directory.GetCurrentDirectory() + "\\测试表格.xlsx");//打开Excel表格
int indexRow = 1;
int indexColumn = 1;
Range range = excel[indexRow, indexColumn];             //获取Excel中指定单元格
while (range.Value2 != null)
{//遍历行
    while (range.Value2 != null)
    {//遍历列
        Console.Write(range.Value2 + "\t");             //输出单元格中内容
        range = excel[indexRow, ++indexColumn];
    }
    indexColumn = 1;
    range = excel[++indexRow, indexColumn];
    Console.WriteLine();
}
excel.QuitExcel();

            Console.ReadLine();
        }
    }
}

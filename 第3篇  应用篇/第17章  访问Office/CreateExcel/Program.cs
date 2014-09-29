using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOperator;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace CreateExcel
{
    class Program
    {
        static void Main(string[] args)
        {

ExcelOperator excel = new ExcelOperator();              //创建Excel操作者
excel.CreateExcel();                                    //创建Excel表格

Console.ReadLine();

SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student_info",
"Data Source=.\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
DataSet dataSet = new DataSet();
adapter.Fill(dataSet);                                  //填充数据集
string[] fields = new string[]{"  学号  ","姓名","年龄","年级","成绩","性别"};
//为学生信息表添加列名
for (int indexColumn = 0; indexColumn < dataSet.Tables[0].Columns.Count; indexColumn++)
{
    Range range = excel[1, indexColumn + 1];
    range.Value2 = fields[indexColumn];
}
//把学生信息表写入到Excel中
for (int indexRow = 0; indexRow < dataSet.Tables[0].Rows.Count; indexRow++)
{
    for (int indexColumn = 0; indexColumn < dataSet.Tables[0].Columns.Count; indexColumn++)
    {
        Range range = excel[indexRow + 2, indexColumn + 1];
        range.Value2 = dataSet.Tables[0].Rows[indexRow][indexColumn];
        if (indexColumn == 4 && range.Value2 < 60)      //标记不合格的学生成绩
            range.Interior.ColorIndex = 6;
    }
}

Range rangeAverage = excel[22, 1];
rangeAverage.Value2 = "平均值";
Range rangeAge = excel[22, 3];
rangeAge.Formula = "=AVERAGE(C2:C21)";                  //计算平均年龄
Range rangeGrade = excel[22, 4];
rangeGrade.Formula = "=AVERAGE(D2:D21)";                //计算平均年级
Range rangeResult = excel[22, 5];
rangeResult.Formula = "=AVERAGE(E2:E21)";               //计算数据成绩


excel.SaveExcel(Directory.GetCurrentDirectory() + "\\测试表格.xlsx");//保存Excel表格

Console.ReadLine();

excel.QuitExcel();                                      //退出Excel应用
        }
    }
}

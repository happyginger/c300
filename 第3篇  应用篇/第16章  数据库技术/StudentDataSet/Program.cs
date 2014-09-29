using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace StudentDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "输出全部学生信息";

SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student_info", 
    "Data Source=.\\SQLExpress;Database=student;Trusted_Connection=true;");
DataSet dataSet = new DataSet();                        //创建数据集对象
adapter.Fill(dataSet);                                  //将查询结构填充到数据集中

foreach (DataRow row in dataSet.Tables[0].Rows)         //逐行输出查询结构
{
    Console.WriteLine("学号：{0} 姓名：{1} 年龄：{2} 年级：{3} 成绩：{4}",
        row[0], row[1], row[2], row[3], row[4]);
}

dataSet.Clear();
adapter.Dispose();

            Console.ReadLine();
        }
    }
}

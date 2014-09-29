using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StudentAlter
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Title = "增加性别字段";

string connectionString =                               //数据库连接字串
    "Data Source=.\\SQLExpress;Database=student;Trusted_Connection=true;";
SqlConnection connection = new SqlConnection(connectionString);//创建数据库连接实例
connection.Open();                                      //打开数据库连接
Console.WriteLine("数据库student连接成功！");

SqlCommand cmd = new SqlCommand();                      //创建数据查询类实例
cmd.Connection = connection;
cmd.CommandText = "ALTER TABLE student_info ADD sex varchar(2)";
cmd.ExecuteNonQuery();                                  //执行添加sex字段SQL语句
cmd.Dispose();

SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student_info",
    "Data Source=.\\SQLExpress;Database=student;Trusted_Connection=true;");
DataSet dataSet = new DataSet();                        //创建数据集
adapter.Fill(dataSet);                                  //填充数据集
for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
{
    dataSet.Tables[0].Rows[i][5] = random.Next(2) == 0 ? "男" : "女";//修改性别值
}
SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//将数据集更新与数据库协调
adapter.Update(dataSet);                                //更新数据集到数据库

builder.Dispose();
dataSet.Dispose();
adapter.Dispose();
connection.Close();                                     //关闭数据库连接

            Console.ReadLine();
        }
    }
}

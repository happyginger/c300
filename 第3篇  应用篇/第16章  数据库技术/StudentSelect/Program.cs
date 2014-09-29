using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StudentSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "查询成绩合格的学生";

string connectionString =                               //数据库连接字串
    "Data Source=.\\SQLExpress;Database=student;Trusted_Connection=true;";
SqlConnection connection = new SqlConnection(connectionString);//创建数据库连接实例
connection.Open();                                      //打开数据库连接
Console.WriteLine("数据库student连接成功！");

SqlCommand cmd = new SqlCommand();                      //创建数据查询类实例
cmd.Connection = connection;
cmd.CommandText = "SELECT * FROM student_info WHERE result>@result";
cmd.Parameters.Add("@result", SqlDbType.Int).Value = 59;
SqlDataReader reader = cmd.ExecuteReader();             //执行查找指令并返回查找结果
Console.WriteLine("成绩合格的学生信息如下：");
while (reader.Read())                                   //逐行读取查询结果
{
    Console.WriteLine("学号：{0} 姓名：{1} 年龄：{2} 年级：{3} 成绩：{4}",
        reader["id"], reader["name"], reader["age"], reader["grade"], reader["result"]);
}

reader.Close();
cmd.Dispose();
connection.Close();                                     //关闭数据库连接

            Console.ReadLine();
        }
    }
}

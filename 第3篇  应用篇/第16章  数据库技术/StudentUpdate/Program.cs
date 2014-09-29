using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace StudentUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "";

string connectionString =                               //数据库连接字串
    "Data Source=.\\SQLExpress;Database=student;Trusted_Connection=true;";
SqlConnection connection = new SqlConnection(connectionString);//创建数据库连接实例
connection.Open();                                      //打开数据库连接
Console.WriteLine("数据库student连接成功！");

SqlCommand cmd = new SqlCommand();                      //创建数据查询类实例
cmd.Connection = connection;
cmd.CommandText = "UPDATE student_info SET result=100 WHERE grade=4";
int count = cmd.ExecuteNonQuery();
if (count > 0) Console.WriteLine("修改student_info表中学生信息成功！");
cmd.Dispose();
connection.Close();                                     //关闭数据库连接


            Console.ReadLine();
        }
    }
}

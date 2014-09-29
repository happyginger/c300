using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "创建并连接学生数据库";

string connectionString = "Data Source=.\\SQLExpress;"; //数据库服务器
connectionString += "Database=student;";                //数据库名称
//是否开启信任连接，如果为true，则使用当前的Windows帐户凭据进行身份验证
connectionString += "Trusted_Connection=true;";
SqlConnection connection = new SqlConnection(connectionString);//创建数据库连接实例
connection.Open();                                      //打开数据库连接
Console.WriteLine("数据库student连接成功！");
connection.Close();                                     //关闭数据库连接

            Console.ReadLine();
        }
    }
}

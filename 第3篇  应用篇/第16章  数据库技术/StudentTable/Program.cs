using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace StudentTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "创建学生信息表";

SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();//数据库连接字串构造器
builder.DataSource = ".\\SQLExpress";                   //设置数据库服务器
builder.InitialCatalog = "student";                     //设置数据库名称
builder.IntegratedSecurity = true;                      //是否启用信任连接
SqlConnection connection = new SqlConnection(builder.ConnectionString);//创建数据库连接实例
connection.Open();                                      //打开数据库连接
Console.WriteLine("数据库student连接成功！");

//创建学生表SQL语句
string cmdText = @"CREATE TABLE student_info(
                    id int not null primary key,
                    name varchar(10) not null,
                    age int not null,
                    grade int not null,
                    result int not null)";
SqlCommand cmd = new SqlCommand(cmdText, connection);   //创建数据查询类实例
cmd.ExecuteNonQuery();                                  //执行查询操作
cmd.Dispose();                                          //释放查询类实例
Console.WriteLine("学生信息表student_info创建成功！");
connection.Close();                                     //关闭数据库连接

            Console.ReadLine();
        }
    }
}

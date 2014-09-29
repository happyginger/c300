using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace StudentInsert
{
    class Program
    {
static readonly string[] surnames = new string[]        //初始化姓数组
    { "郑", "胡", "张", "李", "王", "赵", "周", "刘", "钱", "孙" };
static readonly string[] names = new string[]           //初始化名数组
    { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十" };
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Title = "插入学生信息";

string connectionString =                               //数据库连接字串
    "Data Source=.\\SQLExpress;Database=student;Trusted_Connection=true;";
SqlConnection connection = new SqlConnection(connectionString);//创建数据库连接实例
connection.Open();
Console.WriteLine("数据库student连接成功！");

for (int id = 20120001; id < 20120011; id++)
{
    SqlCommand cmd = new SqlCommand();                  //创建数据查询类实例
    cmd.Connection = connection;
    //插入学生信息SQL语句
    cmd.CommandText = @"INSERT INTO student_info
                    (id,name,age,grade,result,sex)
                    VALUES(@id,@name,@age,@grade,@result,@sex)";
    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;//学号
    cmd.Parameters.Add("@name", SqlDbType.VarChar, 10).Value = surnames[random.Next(10)] + names[random.Next(10)];//姓名
    cmd.Parameters.Add("@age", SqlDbType.Int).Value = random.Next(20,25);   //年龄
    cmd.Parameters.Add("@grade", SqlDbType.Int).Value = random.Next(1,5);  //年级
    cmd.Parameters.Add("@result", SqlDbType.Int).Value = random.Next(0, 101);//成绩
    //cmd.Parameters.Add("@sex", SqlDbType.VarChar, 2).Value = random.Next(2) == 0 ? "男" : "女"; //性别
    int count = cmd.ExecuteNonQuery();                  //执行SQL语句
    if (count > 0) Console.WriteLine("向student_info表中插入学生信息成功！");
    cmd.Dispose();
}
connection.Close();

            Console.ReadLine();
        }
    }
}

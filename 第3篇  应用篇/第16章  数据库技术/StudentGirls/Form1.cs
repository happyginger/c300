using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace StudentGirls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    string connectionString =                               //数据库连接字串
        "Data Source=.\\SQLExpress;Database=student;Trusted_Connection=true;";
    SqlConnection connection = new SqlConnection(connectionString);//创建数据库连接实例
    connection.Open();                                  //打开数据库连接
    SqlCommand cmd = new SqlCommand();
    cmd.Connection = connection;
    cmd.CommandType = CommandType.StoredProcedure;      //指定执行语句为存储过程
    cmd.CommandText = "Procedure_GetGirls";             //存储过程名称
    SqlDataAdapter adapter = new SqlDataAdapter(cmd);   //创建数据库连接
    DataSet dataSet = new DataSet();                    //创建数据集
    adapter.Fill(dataSet);                              //将查询结构填充数据集
    dGVGirls.DataSource = dataSet.Tables[0];            //将数据集绑定到控件上
    connection.Close();                                 //关键数据库连接
}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentGroup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    //创建数据库连接
    SqlDataAdapter adapter = new SqlDataAdapter(
        @"SELECT grade AS 年级,sex AS 性别,COUNT(*) AS 人数,
        SUM(result) AS 总成绩,AVG(result) AS 平均成绩 
        FROM student_info GROUP BY grade,sex ORDER BY 5 DESC",
        "Data Source=.\\SQLExpress;Database=student;Trusted_Connection=true;");
    DataSet dataSet = new DataSet();                    //创建数据集
    adapter.Fill(dataSet);                              //将查询结果填充数据集
    dGVStudent.DataSource = dataSet.Tables[0];          //将数据集绑定到控件
}
    }
}

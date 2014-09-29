using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace StudentGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student_info",
    "Data Source=.\\SQLExpress;Database=student;Trusted_Connection=true;");
    DataSet dataSet = new DataSet();                    //创建数据集对象
    adapter.Fill(dataSet);                              //将查询结果填充到数据集
    dGVStudent.DataSource = dataSet.Tables[0];          //将数据集绑定到控件上
}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ControlListView
{
    public partial class FormListView : Form
    {
        public FormListView()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student_info",
"Data Source=.\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");//查询数据库
    DataSet dataSet = new DataSet();                    //创建数据集
    adapter.Fill(dataSet);                              //填充数据集
    adapter.Dispose();                                  //释放数据库连接
    //为ListView控件添加列名
    listView1.Columns.Add("学号", 60);
    listView1.Columns.Add("姓名",40);
    listView1.Columns.Add("年龄", 40);
    listView1.Columns.Add("年级", 40);
    listView1.Columns.Add("成绩", 40);
    listView1.Columns.Add("性别", 40);
    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
    {
        //为ListView控件添加行
        ListViewItem item = listView1.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
        //为ListView控件每行添加数据
        for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
        {
            item.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString());
        }
    }
    dataSet.Dispose();                                  //释放数据集
}
    }
}

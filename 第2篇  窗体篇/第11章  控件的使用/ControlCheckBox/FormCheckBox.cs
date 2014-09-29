using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlCheckBox
{
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

private void bAccept_Click(object sender, EventArgs e)
{
    string message = string.Empty;                      //记录所选的课程
    foreach (var item in this.Controls)                 //遍历所有的控件
    {
        if (item is CheckBox && (item as CheckBox).Checked)
        {//判断控件是否为CheckBox控件且处于选择状态
            message += (item as CheckBox).Text + "\n";
        }
    }
    if (message != string.Empty)
        MessageBox.Show(message, "你选择的课程有：");
}
    }
}

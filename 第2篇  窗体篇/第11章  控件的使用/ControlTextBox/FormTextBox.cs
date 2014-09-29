using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlTextBox
{
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();

            //textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }

void textBox1_KeyPress(object sender, KeyPressEventArgs e)
{
    if (!Char.IsDigit(e.KeyChar))                       //判断输入的字符是否为十进制数字
    {
        MessageBox.Show("请输入十进制数字!");             //消息提示框
        e.Handled = true;                               //将事件标记为已处理
    }
}


    }
}

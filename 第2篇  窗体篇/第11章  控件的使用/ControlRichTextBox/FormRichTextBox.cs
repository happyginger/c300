using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlRechTextBox
{
    public partial class FormRichTextBox : Form
    {
        public FormRichTextBox()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    for (int i = 0; i < 100; i++)
    {
        richTextBox1.Text += "经典实例300 ";                //向RichTextBox控件中添加文本
    }
    for (int start = 0; start < richTextBox1.TextLength; start += richTextBox1.TextLength / 100)
    {
        richTextBox1.Select(start, 2);                  //选择RichTextBox控件中需要突出显示的文字
        richTextBox1.SelectionColor = Color.Red;        //将文字颜色设置为红色
        richTextBox1.SelectionFont = new Font("黑体", 12);//将字体设置为12号黑体
    }
}
    }
}

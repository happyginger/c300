using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponentFontDialog
{
    public partial class FormFontDialog : Form
    {
        public FormFontDialog()
        {
            InitializeComponent();
        }
private void label1_Click(object sender, EventArgs e)
{
    fontDialog1.Font = this.label1.Font;                //将Label控件字体赋值给FontDialog组件
    if (fontDialog1.ShowDialog() == DialogResult.OK)    //显示FontDialog字体编辑对话框
        this.label1.Font = fontDialog1.Font;            //通过FontDialog修改Label控件的字体
}
    }
}

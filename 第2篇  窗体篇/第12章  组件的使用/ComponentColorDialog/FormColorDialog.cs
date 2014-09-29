using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponentColorDialog
{
    public partial class FormColorDialog : Form
    {
        public FormColorDialog()
        {
            InitializeComponent();
        }

protected override void OnClick(EventArgs e)
{
    if (colorDialog1.ShowDialog() == DialogResult.OK)   //打开颜色编辑对话框
        this.BackColor = colorDialog1.Color;            //设置窗体背景颜色
}
    }
}

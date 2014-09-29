using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponentOpenFileDialog
{
    public partial class FormOpenFileDialog : Form
    {
        public FormOpenFileDialog()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    openFileDialog1.Filter = "图片文件|*.jpg";              //设置筛选器字符串
    openFileDialog1.FileOk += new CancelEventHandler(openFileDialog1_FileOk);
}

void openFileDialog1_FileOk(object sender, CancelEventArgs e)
{
    this.BackgroundImage = new Bitmap(openFileDialog1.FileName);//设置窗体背景图片
}

protected override void OnClick(EventArgs e)
{
    openFileDialog1.ShowDialog();                       //显示打开文件对话框
}
    }
}

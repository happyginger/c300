using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormShowHide
{
    public partial class FormShowHide : Form
    {
        bool increase = true;                           //标记是否增加窗体不透明度
        public FormShowHide()
        {
            InitializeComponent();
        }
private void timer1_Tick(object sender, EventArgs e)
{
    if (this.Opacity < .02) increase = true;            //标记增加窗体不透明度
    if (this.Opacity > .98) increase = false;           //标记减小窗体不透明度
    if (increase) this.Opacity += .02d;                 //增加窗体不透明度
    else this.Opacity -= .02;                           //减小窗体不透明度
    if (this.Opacity < .2) this.Hide();                 //隐藏窗体
    else this.Show();                                   //显示窗体
}
    }
}

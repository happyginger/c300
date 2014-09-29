using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace FormSpecial
{
    public partial class FormSpecial : Form
    {
        public FormSpecial()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    int R = 100;                                        //圆角半径
    GraphicsPath path = new GraphicsPath();             //图形路径
    path.AddArc(this.Width - R, this.Height - R, R, R, 0, 90);//添加右下圆角
    path.AddArc(0, this.Height - R, R, R, 90, 90);      //添加左下圆角
    path.AddArc(0, 0, R, R, 180, 90);                   //添加左上圆角
    path.AddArc(this.Width - R, 0, R, R, 270, 90);      //添加右上圆角
    path.CloseAllFigures();                             //闭合路径
    this.Region = new Region(path);                     //设置窗体有效区域
}
    }
}

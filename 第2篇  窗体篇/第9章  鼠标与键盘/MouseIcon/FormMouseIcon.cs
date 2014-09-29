using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MouseIcon
{
    public partial class FormMouseIcon : Form
    {
        public FormMouseIcon()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    Bitmap icon = new Bitmap(Cursor.Size.Width, Cursor.Size.Height);//创建鼠标图标
    Graphics G = Graphics.FromImage(icon);              //获取鼠标图标绘图表面
    G.SmoothingMode = SmoothingMode.AntiAlias;          //开启消除锯齿效果
    G.Clear(Color.Transparent);                         //将图标背景设置为透明
    G.FillPie(new SolidBrush(Color.FromArgb(150,Color.Black))//绘制扇形区域作为鼠标指针
        , new Rectangle(0, 0, icon.Width, icon.Height), 30f, 30f);
    G.Dispose();                                        //释放绘图表面
    this.Cursor = new Cursor(icon.GetHicon());          //为窗体重新设置新的鼠标对象
    icon.Dispose();
}
    }
}

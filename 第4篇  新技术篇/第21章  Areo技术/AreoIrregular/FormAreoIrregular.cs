using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using AreoLibrary;

namespace AreoIrregular
{
    public partial class FormAreoIrregular : Form
    {
        public FormAreoIrregular()
        {
            InitializeComponent();
        }

protected override void OnPaint(PaintEventArgs e)
{
e.Graphics.Clear(Color.FromArgb(50, Color.Fuchsia));    //设置窗体透明色
}

protected override void OnLoad(EventArgs e)
{
GraphicsPath path = new GraphicsPath();
Rectangle rect = this.ClientRectangle;
Size size = new Size(20, 20);
path.AddArc(0, 0, size.Width, size.Height, 180, 90);
path.AddArc(rect.Width - size.Width, 0, size.Width, size.Height, 270, 90);
path.AddArc(rect.Width - size.Width, rect.Height - size.Height, size.Width, size.Height, 0, 90);
path.AddArc(0, rect.Height - size.Height, size.Width, size.Height, 90, 90);
path.CloseFigure();
this.Region = new Region(path);                         //创建圆角矩形区域
path.Dispose();
Areo.AreoParams parameter = new Areo.AreoParams();
parameter.Flags = Areo.AreoParams.ENABLE;
parameter.Enable = true;
parameter.AreoRegion = IntPtr.Zero;
Areo.AreoWindow(this.Handle, parameter);                //将整个窗体背景设置成Areo效果
}
    }
}

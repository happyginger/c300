using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDIDrawImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

Graphics G = e.Graphics;                                //绘图对象
Bitmap image = new Bitmap("lena.jpg");                  //从图像中加载位图实例
G.InterpolationMode = InterpolationMode.HighQualityBicubic;//设置插补模式
G.DrawImage(image, 0,0);                                //在指定点域绘制图像
G.DrawImage(image, new Rectangle(0, 0, 150, 150));      //在指定矩形区域绘制图像
G.DrawImage(image, new Point[]{new Point(300,0), new Point(300,150), new Point(150,0)});
Rectangle rectSource = new Rectangle(150, 150, 250, 250);//图像中的区域
Rectangle rectDest = new Rectangle(300, 0, 150, 150);   //绘图区中的区域
//将图像中指定区域绘制到绘图区指定区域中
G.DrawImage(image, rectDest, rectSource, GraphicsUnit.Pixel);
image.Dispose();                                        //释放位图资源

        }
    }
}

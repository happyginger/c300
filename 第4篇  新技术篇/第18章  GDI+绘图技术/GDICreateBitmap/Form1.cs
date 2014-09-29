using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace GDICreateBitmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
SetStyle(ControlStyles.AllPaintingInWmPaint             //忽略窗体WM_ERASEBKGND消息
| ControlStyles.OptimizedDoubleBuffer                   //开启又缓存，控件首先在缓冲区中绘制
| ControlStyles.UserPaint, true);                       //开启控件自行绘制
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

Graphics GForm = e.Graphics;                            //窗体绘图对象
//创建渐变画刷
LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(10, 10), Color.Yellow, Color.Lime);
brush.WrapMode = WrapMode.TileFlipXY;
GForm.FillRectangle(brush, this.ClientRectangle);       //绘制窗体背景
Bitmap image = new Bitmap(100, 100);                    //创建位图
Graphics GImage = Graphics.FromImage(image);            //创建图像绘图对象
GImage.SmoothingMode = SmoothingMode.AntiAlias;         //抗锯齿
GImage.CompositingMode = CompositingMode.SourceCopy;    //源色与背景色的组合模式
GImage.Clear(Color.White);                              //将图像背景设置成白色
Pen pen = new Pen(Color.FromArgb(200,255,0,0), 5f);     //创建透明度为200的红色钢笔
GImage.DrawRectangle(pen, 10, 10, 80, 80);              //在图像中绘制矩形
GImage.DrawLine(pen, 0, 50, 99, 50);                    //在图像中绘制线段
GImage.DrawLine(pen, 50, 0, 50, 99);                    //在图像中绘制线段
GImage.FillPie(new SolidBrush(Color.FromArgb(200,255,0,255)),
    new Rectangle(20, 20, 60, 60), 45, 270);            //在图像中绘制扇形
GForm.DrawImage(image, 0, 0, 150, 150);                 //将图像绘制在窗体上
float[][] newColorMatrix = new float[][]{               //颜色变换矩形
    new float[]{0.2f,0,0,0,0},                          //红色分量
    new float[]{0,0.6f,0,0,0},                          //绿色分量
    new float[]{0,0,0.2f,0,0},                          //蓝色分量
    new float[]{0,0,0,0.8f,0},                          //透明度分量
    new float[]{0,0,0,0,1}};                            //始终为1
ColorMatrix colorMatrix = new ColorMatrix(newColorMatrix);
ImageAttributes imageAttributes = new ImageAttributes();
imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
GForm.DrawImage(image, new Rectangle(150, 0, 150, 150), 0, 0, 100, 100,  GraphicsUnit.Pixel, imageAttributes);

brush.Dispose();
image.Dispose();
pen.Dispose();
        }
    }
}

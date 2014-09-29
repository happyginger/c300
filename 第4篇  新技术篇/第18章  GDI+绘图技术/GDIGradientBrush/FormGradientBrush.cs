using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDIGradientBrush
{
    public partial class FormGradientBrush : Form
    {
        public FormGradientBrush()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

Graphics G = e.Graphics;
LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush(//创建线性渐变画刷
    new Point(0, 0),new Point(20, 20),                  //渐变起始点和终止点
    Color.Yellow,Color.Blue);                           //渐变起始颜色和终止颜色
G.FillRectangle(linearGradientBrush1, new Rectangle(0, 0, 150, 150));//绘制矩形
LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(//创建线性渐变画刷
    new Rectangle(0, 0, 20, 20),                      //渐变所在矩形
    Color.Yellow, Color.Blue, 60f);                     //渐变起始颜色、终止颜色以及渐变方向
linearGradientBrush2.WrapMode = WrapMode.TileFlipXY;
G.FillRectangle(linearGradientBrush2, new Rectangle(150, 0, 150, 150));//绘制矩形

GraphicsPath graphicsPath1 = new GraphicsPath();        //创建绘制路径
graphicsPath1.AddArc(new Rectangle(0, 150, 100, 100), 90, 180);//向路径中添加半左圆弧
graphicsPath1.AddArc(new Rectangle(150, 150, 100, 100), 270, 180);//向路径中添加半右圆弧
graphicsPath1.CloseFigure();                            //闭合路径
PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath1);//创建路径渐变画刷
pathGradientBrush.CenterColor = Color.Yellow;           //指定画刷中心颜色
pathGradientBrush.SurroundColors = new Color[] { Color.Blue };//指定画刷周边颜色
pathGradientBrush.CenterPoint = new PointF(125, 200);   //指定画刷中心点坐标
G.SmoothingMode = SmoothingMode.AntiAlias;              //消锯齿
G.FillPath(pathGradientBrush, graphicsPath1);           //利用画刷填充路径
G.DrawPath(new Pen(Color.Lime, 3f), graphicsPath1);     //绘制闭合路径曲线

linearGradientBrush1.Dispose();
linearGradientBrush2.Dispose();
graphicsPath1.Dispose();
pathGradientBrush.Dispose();

        }
    }
}

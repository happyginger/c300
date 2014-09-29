using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageProcessingLibrary;

namespace SplitImage
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

Graphics G = e.Graphics;
Bitmap image = new Bitmap("cell_small.jpg");            //加载图像
Rectangle rectImage = new Rectangle(new Point(), image.Size);
G.DrawImage(image, rectImage);                          //绘制原始图像
int[] histogram;                                        //直方图统计数组
Rectangle rectHistogram = new Rectangle(rectImage.Width, 0, 256, 256);
//获取图像的灰度直方图
Bitmap imageHistogram = ImageProcessing.GetHistogram(image, 0, out histogram);
G.DrawImage(imageHistogram, rectHistogram);             //绘制直方图
rectImage.Offset(0, image.Height);
ImageProcessing.BinaryImage(image, 0, 0, 130);          //通过二值化将目标分割出来
G.DrawImage(image, rectImage);                          //绘制分割后的图像
image.Dispose();                                        //释放图像
imageHistogram.Dispose();                               //释放直方图图像
            
        }


    }
}

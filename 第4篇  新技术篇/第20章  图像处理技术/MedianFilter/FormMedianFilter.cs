using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using ImageProcessingLibrary;

namespace MedianFilter
{
    public partial class FormMedianFilter : Form
    {
        public FormMedianFilter()
        {
            InitializeComponent();
        }

protected override void OnPaint(PaintEventArgs e)
{
    base.OnPaint(e);

Graphics G = e.Graphics;
Bitmap image = new Bitmap("apple.jpg");                 //加载图像
Random random = new Random();
Rectangle rectImage = new Rectangle(new Point(), image.Size);
for (int i = 0; i < 500; i++)
{
image.SetPixel(random.Next(image.Width), random.Next(image.Height), Color.FromArgb(random.Next(int.MaxValue)));//随机产生噪点
}
G.DrawImage(image, rectImage);              //绘制原始图像
ImageProcessing.MedianFilter(image);//中值滤波处理
rectImage.Offset(0, rectImage.Height);
G.DrawImage(image, rectImage);              //绘制中值滤波后的图像
image.Dispose();
}
    }
}

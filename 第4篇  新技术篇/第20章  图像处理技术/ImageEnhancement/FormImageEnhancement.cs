using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageProcessingLibrary;

namespace ImageEnhancement
{
    public partial class FormImageEnhancement : Form
    {
        public FormImageEnhancement()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

Graphics G = e.Graphics;
Bitmap image = new Bitmap("bird.gif");                 //加载图像
Rectangle rectImage = new Rectangle(new Point(), image.Size);
Rectangle rectHistogram = new Rectangle(rectImage.Width, rectImage.Top, 256, 256);
int[] histogram;
Bitmap imageHistogram = ImageProcessing.GetHistogram(image, 0, out histogram);
G.DrawImage(image, rectImage);                          //绘制原始图像
G.DrawImage(imageHistogram, rectHistogram);             //绘制原始直方图
ImageProcessing.EnhanceImage(image, 0, 100, 0, 255);
imageHistogram = ImageProcessing.GetHistogram(image, 0, out histogram);
rectImage.Offset(0, Math.Max(rectImage.Height, 256));
rectHistogram.Offset(0, Math.Max(rectImage.Height, 256));
G.DrawImage(image, rectImage);                          //绘制增强图像
G.DrawImage(imageHistogram, rectHistogram);             //绘制增强直方图
image.Dispose();
imageHistogram.Dispose();
        }
    }
}

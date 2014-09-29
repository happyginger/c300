using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageProcessingLibrary;

namespace FeatureExtraction
{
    public partial class FormFeatureExtraction : Form
    {
        public FormFeatureExtraction()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

Graphics G = e.Graphics;
Bitmap image = new Bitmap("fruit.jpg");                 //加载图像
Rectangle rectImage = new Rectangle(new Point(), image.Size);
ImageProcessing.GreyImage(image);                       //将图像转换成灰度图像
G.DrawImage(image, rectImage);
rectImage.Offset(rectImage.Width, 0);
ImageProcessing.BinaryImage(image, 0, 0, 250);          //将目标从背景中提取出来
G.DrawImage(image, rectImage);
rectImage.Offset(-rectImage.Width, rectImage.Height);
ImageProcessing.MedianFilter(image);                    //利用中值滤波消除噪点
G.DrawImage(image, rectImage);
rectImage.Offset(rectImage.Width, 0);
ImageProcessing.ConnectRegion(image);                   //对目标进行区域标记
G.DrawImage(image, rectImage);
image.Dispose();
        }
    }
}

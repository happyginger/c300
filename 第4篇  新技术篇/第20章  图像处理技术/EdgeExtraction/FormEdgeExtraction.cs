using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using ImageProcessingLibrary;

namespace EdgeExtraction
{
    public partial class FormEdgeExtraction : Form
    {
        public FormEdgeExtraction()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
Graphics G = e.Graphics;
Bitmap image = new Bitmap("apple.jpg");                 //加载图像
ImageProcessing.GreyImage(image);                       //生成灰度图像
Rectangle rectImage = new Rectangle(new Point(), image.Size);
G.DrawImage(image, rectImage);

rectImage.Offset(rectImage.Width, 0);
ImageProcessing.ExtractEdge(image);                     //提取边缘
G.DrawImage(image, rectImage);

rectImage.Offset(-rectImage.Width, rectImage.Height);
Bitmap image2 = image.Clone() as Bitmap;
ImageProcessing.BinaryImage(image2, 0, 20, 255);        //在灰度20到255的范围提取边界
G.DrawImage(image2, rectImage);

image2.Dispose();

rectImage.Offset(rectImage.Width, 0);
ImageProcessing.BinaryImage(image, 0, 40, 255);         //在灰度40到255的范围提取边界
G.DrawImage(image, rectImage);

image.Dispose();
        }
    }
}

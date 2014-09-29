using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageProcessingLibrary;

namespace Transformation
{
    public partial class FormTransformation : Form
    {
        public FormTransformation()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

Graphics G = e.Graphics;
Bitmap image = new Bitmap("lena.jpg");                 //加载图像
Rectangle rectImage = new Rectangle(new Point(), image.Size);
G.DrawImage(image, rectImage);                          //绘制原始图像
rectImage.Offset(rectImage.Width, 0);
ImageProcessing.Dilation(image, 0.5f, 0.5f);            //对图像进行缩小处理
G.DrawImage(image, rectImage);
rectImage.Offset(-rectImage.Width, rectImage.Height);
ImageProcessing.Translation(image, image.Width / 4, image.Height / 4);//将图像平移居中
G.DrawImage(image, rectImage);
rectImage.Offset(rectImage.Width, 0);
//将图像围绕中心点逆时针旋转45度
ImageProcessing.Rotation(image, 45, new Point(image.Width / 2, image.Height / 2));
G.DrawImage(image, rectImage);
image.Dispose();

        }
    }
}

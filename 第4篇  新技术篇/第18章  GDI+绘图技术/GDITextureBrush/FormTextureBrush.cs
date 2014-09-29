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

namespace GDITextureBrush
{
    public partial class FormTextureBrush : Form
    {
        public FormTextureBrush()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

Graphics G = e.Graphics;
//利用位图作为纹理创建纹理画刷
TextureBrush textureBrush1 = new TextureBrush(Properties.Resources.test);
G.FillRectangle(textureBrush1, 40, 0, 40, 120);
G.FillRectangle(textureBrush1, 0, 40, 120, 40);
//利用位置的指定区域作为纹理创建纹理画刷
TextureBrush textureBrush2 = new TextureBrush(Properties.Resources.test, new Rectangle(10, 10, 28, 28));
G.FillRectangle(textureBrush2, 180, 0, 40, 120);
G.FillRectangle(textureBrush2, 140, 40, 120, 40);
TextureBrush textureBrush3 = new TextureBrush(Properties.Resources.test, new Rectangle(10, 10, 28, 28));
textureBrush3.WrapMode = WrapMode.TileFlipXY;           //设置纹理图像的渐变方式
G.FillRectangle(textureBrush3, 30, 140, 60, 120);
G.FillRectangle(textureBrush3, 0, 170, 120, 60);
float[][] newColorMatrix = new float[][]{               //颜色变换矩形
    new float[]{0.2f,0,0,0,0},                          //红色分量
    new float[]{0,0.6f,0,0,0},                          //绿色分量
    new float[]{0,0,0.2f,0,0},                          //蓝色分量
    new float[]{0,0,0,0.5f,0},                          //透明度分量
    new float[]{0,0,0,0,1}};                            //始终为1
ColorMatrix colorMatrix = new ColorMatrix(newColorMatrix);
ImageAttributes imageAttributes = new ImageAttributes();
imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
TextureBrush textureBrush4 = new TextureBrush(Properties.Resources.test, new Rectangle(0, 0, 48, 48), imageAttributes);
textureBrush4.WrapMode = WrapMode.TileFlipXY;
G.FillRectangle(textureBrush4, 170, 140, 60, 120);
G.FillRectangle(textureBrush4, 140, 170, 120, 60);
textureBrush1.Dispose();                                //释放画刷
textureBrush2.Dispose();                                //释放画刷
textureBrush3.Dispose();                                //释放画刷
textureBrush4.Dispose();                                //释放画刷
        }
    }
}

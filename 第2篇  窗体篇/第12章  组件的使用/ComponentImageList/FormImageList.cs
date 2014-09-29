using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ComponentImageList
{
    public partial class FormImageList : Form
    {
        int index = 0;
        public FormImageList()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    for (int i = 0; i < 90; i+=3)
    {
        Bitmap image = new Bitmap(200, 200);            //创建动画图像
        using (Graphics G = Graphics.FromImage(image))
        {
            G.SmoothingMode = SmoothingMode.AntiAlias;
            G.TranslateTransform(100, 100);
            G.RotateTransform(i);                       //旋转绘图表面
            G.FillRectangle(Brushes.Blue, -75, -75, 150, 150);//绘制矩形
        }
        imageList1.Images.Add(image);
    }
    timer1.Start();
}

private void timer1_Tick(object sender, EventArgs e)
{
    pictureBox1.Image = imageList1.Images[index++];     //显示动画帧
    index %= imageList1.Images.Count;
}
    }
}

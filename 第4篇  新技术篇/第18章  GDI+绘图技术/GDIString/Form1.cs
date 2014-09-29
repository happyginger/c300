using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace GDIString
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

            //床前明月光，疑是地上霜。举头望明月，低头思故乡。

Graphics G = e.Graphics;
G.TextRenderingHint = TextRenderingHint.AntiAlias;      //消除文本锯齿
FontFamily fontFamily = new FontFamily("楷体");         //创建“楷体”字体家族
//创建高度为20像素、粗体字体
Font font1 = new Font(fontFamily,20f, FontStyle.Bold, GraphicsUnit.Pixel);
string poem1 = "床前明月光，";
G.DrawString(poem1, font1, Brushes.Black, 0, 10);       //在窗体（0，10）点绘制文本
//创建宋体、20像素、斜体字体
Font font2 = new Font("宋体", 20f, FontStyle.Italic, GraphicsUnit.Pixel);
string poem2 = "疑是地上霜。";
SizeF size2 = G.MeasureString(poem2, font2);            //测试字符串的所占的宽和高
RectangleF rect2 = new RectangleF(0, 40, size2.Width, size2.Height);
G.DrawRectangle(Pens.Red, rect2.X, rect2.Y, rect2.Width, rect2.Height);
G.DrawString(poem2, font2, Brushes.Red, rect2);         //在指定矩形内绘制文本
//创建黑体、高20像素、带有删除线、斜体字体
Font font3 = new Font("黑体", 20f, FontStyle.Strikeout | FontStyle.Italic, GraphicsUnit.Pixel);
Rectangle rect3 = new Rectangle(0, 70, 150,50);         //指定文本绘制区域
StringFormat sf3 = new StringFormat();                  //创建字符串格式化类
sf3.Alignment = StringAlignment.Center;                 //设置字符水平对齐方式：居中
sf3.LineAlignment = StringAlignment.Center;             //设置字符垂直对齐方式：居中
string poem3 = "举头望明月，";
G.DrawRectangle(Pens.Green, rect3);
G.DrawString(poem3, font3, Brushes.Green, rect3, sf3);  //按指定字字符串格式绘制文本
//创建幼圆体、高20像素、带下划线、粗体字体
Font font4 = new Font("幼圆", 20f, FontStyle.Underline | FontStyle.Bold, GraphicsUnit.Pixel);
StringFormat sf4 = new StringFormat(    //创建字符串格式化类，设置文本垂直、从右向左绘制
    StringFormatFlags.DirectionVertical | StringFormatFlags.DirectionRightToLeft);
Rectangle rect4 = new Rectangle(0, 120, 50, 100);
string poem4 = "低头思故乡。";
G.DrawRectangle(Pens.Blue, rect4);
G.DrawString(poem4, font4, Brushes.Blue, rect4, sf4);   //按指定字字符串格式绘制文本
string familyName = "华文行楷";
if (listBox1.SelectedItem != null)
    familyName = listBox1.SelectedItem.ToString();      //从列表控件中获取字体家族
Font font = new Font(familyName, 25f);                  //创建高25像素的用户指定字体家族的字体
StringBuilder poem = new StringBuilder();
poem.Append(poem1).Append(poem2).Append(poem3).Append(poem4);//拼接字符串
HatchBrush hatchBrush = new HatchBrush(HatchStyle.Cross, Color.Lime);//创建阴影画刷
Rectangle rect = new Rectangle(150, 0, 150, 260);
G.DrawRectangle(Pens.Lime, rect);
G.DrawString(poem.ToString(), font, hatchBrush, rect);  //在指定区域用指定画刷指定字体绘制文本

hatchBrush.Dispose();
        }

protected override void OnLoad(EventArgs e)
{
    //安装在系统上的字体类
    InstalledFontCollection installedFontCollection = new InstalledFontCollection();
    foreach (var item in installedFontCollection.Families)
    {
        listBox1.Items.Add(item.Name);                  //将所有安装的字体加入到列表控件中
    }
    listBox1.SelectedItem = "华文行楷";                 //默认字体为“华文行楷”
    base.OnLoad(e);
}

private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    this.Invalidate();                                  //窗体重绘
}

    }
}

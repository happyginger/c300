using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AreoLibrary;

namespace AreoRegion
{
    public partial class FormAreoRegion : Form
    {
        Region regionAreo = new Region();
        public FormAreoRegion()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);        //在调整窗体大小时重绘窗体
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
switch (cBAreo.CheckState)
{
    case CheckState.Checked:
        e.Graphics.Clear(Color.Black);                  //将窗体整个背景绘制成黑色
        break;
    case CheckState.Indeterminate:
        Rectangle rect = this.ClientRectangle;
        rect.Inflate(-20, -20);
        Region region = new Region(rect);
        rect.Inflate(-20, -20);
        region.Exclude(rect);                           //获取非Areo区域部分区域
        e.Graphics.FillRegion(Brushes.Black, region);   //窗体部分非Areo区域全透明
        e.Graphics.FillRegion(Brushes.Black, regionAreo);//将窗体Areo边框绘制成黑色
        break;
}
        }

        private void cBAreo_CheckStateChanged(object sender, EventArgs e)
        {
Areo.AreoParams parameter;
switch (cBAreo.CheckState)
{
    case CheckState.Checked:
        cBAreo.Text = "窗体背景Areo效果";
        parameter = new Areo.AreoParams();
        parameter.Flags = Areo.AreoParams.ENABLE;       //开启Areo效果
        parameter.Enable = true;                        //开启Areo效果
        parameter.AreoRegion = IntPtr.Zero;             //区域为整个窗体背景区
        Areo.AreoWindow(this.Handle, parameter);        //将整个窗体背景设置为Areo效果
        break;
    case CheckState.Indeterminate:
        cBAreo.Text = "窗体区域Areo效果";
        ClearAreoWindow();                              //清除原有Areo效果
        using (Graphics G = CreateGraphics())
        {
            parameter = new Areo.AreoParams();
            //开启Areo效果和区域Areo效果
            parameter.Flags = Areo.AreoParams.ENABLE | Areo.AreoParams.REGION;
            parameter.Enable = true;                    //开启Areo效果
            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-rect.Width / 4, -rect.Height / 4);
            regionAreo = new Region(rect);              //获取窗体中心区域
            parameter.AreoRegion = regionAreo.GetHrgn(G);//设置Areo区域
            Areo.AreoWindow(this.Handle, parameter);    //将窗体中心区域设置成Areo效果
        }
        break;
    case CheckState.Unchecked:
        cBAreo.Text = "窗体无Areo效果";
        ClearAreoWindow();
        break;
    default:
        break;
}
this.Invalidate();
        }

void ClearAreoWindow()
{
    Areo.AreoParams parameter = new Areo.AreoParams();
    parameter.Flags = Areo.AreoParams.ENABLE | Areo.AreoParams.REGION;
    parameter.Enable = false;                           //关闭Areo效果
    parameter.AreoRegion = IntPtr.Zero;
    Areo.AreoWindow(this.Handle, parameter);
}
    }
}

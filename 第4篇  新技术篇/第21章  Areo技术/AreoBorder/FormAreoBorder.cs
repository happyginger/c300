using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AreoLibrary;

namespace AreoBorder
{
    public partial class FormAreoBorder : Form
    {
        public FormAreoBorder()
        {
this.SetStyle(ControlStyles.ResizeRedraw, true);        //在调整窗体大小时重绘窗体
            InitializeComponent();
        }

protected override void OnPaint(PaintEventArgs e)
{
    if (Areo.IsAreoEnabled())                        //检测系统是否开启Areo功能
    {
        switch (cBAreo.CheckState)
        {
            case CheckState.Checked:
                e.Graphics.Clear(Color.Black);          //将窗体整个背景绘制成黑色
                break;
            case CheckState.Indeterminate:
                Region region = new Region(this.ClientRectangle);
                Rectangle rect = this.ClientRectangle;
                rect.Inflate(-50, -50);
                region.Exclude(rect);
                e.Graphics.FillRegion(Brushes.Black, region);//将窗体Areo边框绘制成黑色
                break;
        }
    }
}

private void cBAreo_CheckStateChanged(object sender, EventArgs e)
{
    if (!Areo.IsAreoEnabled())                       //检测系统是否开启Areo功能
    {
        MessageBox.Show("系统未开启Areo效果");
        cBAreo.CheckState = CheckState.Unchecked;
        cBAreo.Text = "窗体无Areo效果";
        return;
    }
    switch (cBAreo.CheckState)
    {
        case CheckState.Checked:
            cBAreo.Text = "整个窗体Areo效果";
            Areo.AreoFrame(this.Handle, new Areo.Margin(-1, 0, 0, 0));
            break;
        case CheckState.Indeterminate:
            cBAreo.Text = "窗体边框Areo效果";
            Areo.AreoFrame(this.Handle, new Areo.Margin(50, 50, 50, 50));
            break;
        case CheckState.Unchecked:
            cBAreo.Text = "窗体无Areo效果";
            Areo.AreoFrame(this.Handle, new Areo.Margin(0, 0, 0, 0));
            break;
        default:
            break;
    }
    this.Invalidate();
}
    }
}

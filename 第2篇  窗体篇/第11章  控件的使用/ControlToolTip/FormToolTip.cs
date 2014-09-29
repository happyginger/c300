using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlToolTip
{
    public partial class FormToolTip : Form
    {
        public FormToolTip()
        {
            InitializeComponent();
        }

private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
{
    e.Graphics.FillRectangle(Brushes.Lime, e.Bounds);   //填充气泡背景
    e.DrawText();                                       //在气泡内绘制文本
}
    }
}

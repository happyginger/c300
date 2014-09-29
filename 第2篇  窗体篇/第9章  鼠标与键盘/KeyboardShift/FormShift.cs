using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardShift
{
    public partial class FormShift : Form
    {
        public FormShift()
        {
            InitializeComponent();
        }

protected override void OnKeyDown(KeyEventArgs e)
{
    if (e.KeyData == (Keys.Shift | Keys.Left)) this.Width -= 100;//减小窗体宽度
    if (e.KeyData == (Keys.Shift | Keys.Right)) this.Width += 100;//增加窗体宽度
    if (e.KeyData == (Keys.Shift | Keys.Up)) this.Height -= 100;//减小窗体高度
    if (e.KeyData == (Keys.Shift | Keys.Down)) this.Height += 100;//增加窗体高度

    this.Text = "使用Shift+方向键调整窗体大小" 
        + string.Format("({0},{1})", this.Width, this.Height);
}
    }
}

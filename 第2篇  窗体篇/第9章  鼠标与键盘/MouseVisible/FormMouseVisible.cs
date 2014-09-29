using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseVisible
{
    public partial class FormMouseVisible : Form
    {
        public FormMouseVisible()
        {
            InitializeComponent();
        }

protected override void OnMouseDown(MouseEventArgs e)
{
    this.Text = "鼠标已按下";
    Cursor.Hide();                                      //隐藏鼠标
}

protected override void OnMouseUp(MouseEventArgs e)
{
    this.Text = "鼠标已抬起";
    Cursor.Show();                                      //显示鼠标
}
    }
}

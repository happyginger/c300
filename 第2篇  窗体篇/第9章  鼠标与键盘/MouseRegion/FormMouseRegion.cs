using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseRegion
{
    public partial class FormMouseRegion : Form
    {
        public FormMouseRegion()
        {
            InitializeComponent();
        }

protected override void OnMouseMove(MouseEventArgs e)
{
    if (e.X < ClientSize.Width / 2)
        if (e.Y < ClientSize.Height / 2)
            this.Cursor = Cursors.Hand;                 //鼠标为手形图标
        else
            this.Cursor = Cursors.Help;                 //鼠标为帮助图标
    else
        if (e.Y < ClientSize.Height / 2)
            this.Cursor = Cursors.WaitCursor;           //鼠标为等待图标
        else
            this.Cursor = Cursors.Cross;                //鼠标为十字图标
}
    }
}

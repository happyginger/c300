using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CustomControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            //for (long i = 201209010001; i < 201209010100; i++)
            //{
            //    mouseListBox1.AddItem(i);
            //}
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics G = e.Graphics;
            LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0), new Point(20, 20), Color.Blue, Color.Green);
            brush.WrapMode = WrapMode.TileFlipXY;
            G.FillRectangle(brush, this.ClientRectangle);
            brush.Dispose();
        }

private void switchCheckBox1_CheckedChanged(object sender, EventArgs e)
{
    if (switchCheckBox1.Checked) MessageBox.Show(switchCheckBox1.OpenedString);
    else MessageBox.Show(switchCheckBox1.ClosedString);
}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ComponentTimer
{
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

private void timer1_Tick(object sender, EventArgs e)
{
    label1.Text = DateTime.Now.ToString("HH点mm分ss秒fff毫秒");//显示当前时间
}
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlContextMenuStrip
{
    public partial class FormContextMenuStrip : Form
    {
        public FormContextMenuStrip()
        {
            InitializeComponent();
        }

private void tSMIExit_Click(object sender, EventArgs e)
{
    this.Close();                                       //退出程序
}


    }
}

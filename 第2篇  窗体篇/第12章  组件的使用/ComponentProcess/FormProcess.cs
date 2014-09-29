using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ComponentProcess
{
    public partial class FormProcess : Form
    {
        public FormProcess()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    process1.StartInfo.FileName = "cmd.exe";            //设置进程文件名
}

protected override void OnMouseClick(MouseEventArgs e)
{
    if (e.Button == MouseButtons.Left)
    {
        process1.Start();                               //启动进程
        MessageBox.Show("控制台窗体打开成功！");
    }
    else if (e.Button == MouseButtons.Right)
    {
        foreach (Process p in Process.GetProcessesByName("cmd"))
        {
            p.CloseMainWindow();                        //关闭进程窗口
            p.Close();                                  //关闭进程
        }
        MessageBox.Show("控制台窗体关闭成功！");
    }
}
    }
}

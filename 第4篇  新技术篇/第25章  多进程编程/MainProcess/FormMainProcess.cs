using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace MainProcess
{
    public partial class FormMainProcess : Form
    {
public FormMainProcess()
{
    InitializeComponent();
}

private void btnStart_Click(object sender, EventArgs e)
{
    //启动子进程
    Process subProcess = Process.Start(Directory.GetCurrentDirectory() + "\\" + "SubProcess.exe");
}

private void btnGetProcess_Click(object sender, EventArgs e)
{
    lBProcess.Items.Clear();
    //获取当前已打开的子进程信息
    Process[] subProcesses = Process.GetProcessesByName("SubProcess", ".");
    foreach (Process p in subProcesses)
    {
        //输出子进程信息
        lBProcess.Items.Add(String.Format("ID {0} MainWindowTitle {1} ProcessName {2}", p.Id, p.MainWindowTitle, p.ProcessName));
    }
}
    }
}

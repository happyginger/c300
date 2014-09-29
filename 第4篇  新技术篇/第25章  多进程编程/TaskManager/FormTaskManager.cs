using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManager
{
    public partial class FormTaskManager : Form
    {
        public FormTaskManager()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    GetProcesses();                                     //获取进程信息列表
    base.OnLoad(e);
}

private void GetProcesses()
{
    lVProcess.Items.Clear();                        //清空列表视频
    Process[] processes = Process.GetProcesses();   //获取本地计算机上所有进程
    foreach (Process p in processes)                //遍历每个进程
    {
        ListViewItem item = new ListViewItem();
        item.Text = p.ProcessName;              //获取进程名称
        //将进程ID和进程所占内存大小添加到列表视图中
        item.SubItems.AddRange(new string[] { p.Id.ToString(), 
            p.PrivateMemorySize64.ToString(), p.MainModule.FileName });
        lVProcess.Items.Add(item);
    }
}

private void btnKillProcess_Click(object sender, EventArgs e)
{
    if (lVProcess.SelectedItems.Count > 0)
    {
        //获取用户选择需要关闭的进程
        string processName = lVProcess.SelectedItems[0].Text;
        int processID = int.Parse(lVProcess.SelectedItems[0].SubItems[1].Text);//获取进程ID
        if (MessageBox.Show("您确定要关闭进程" + processName + "吗?", "关闭进程",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
            Process p = Process.GetProcessById(processID);
            p.Kill();                                   //关闭进程
        }
    }
}

private void btnRefresh_Click(object sender, EventArgs e)
{
    GetProcesses();                                     //刷新进程信息列表
}
    }
}

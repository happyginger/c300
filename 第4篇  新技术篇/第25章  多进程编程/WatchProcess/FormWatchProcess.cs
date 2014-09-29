using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WatchProcess
{
    public partial class FormWatchProcess : Form
    {
public FormWatchProcess()
{
    InitializeComponent();
}

private void cBStartWatch_CheckedChanged(object sender, EventArgs e)
{
    tWatch.Enabled = cBStartWatch.Checked;              //开启或关闭计时器
}

private void bAddProcess_Click(object sender, EventArgs e)
{
    oFDProcess.ShowDialog();                            //打开添加文件对话框
}

private void oFDProcess_FileOk(object sender, CancelEventArgs e)
{

    OpenFileDialog ofd = sender as OpenFileDialog;      //获取开启文件对话框组合
    if (!lBProcess.Items.Contains(ofd.FileName))
    {
        lBProcess.Items.Add(ofd.FileName);              //将用户选择的执行文件添加到进程列表中
    }
    else
    {
        MessageBox.Show("进程已经启动");
    }
}

private void tWatch_Tick(object sender, EventArgs e)
{

    Process[] processes = Process.GetProcesses();       //获取本地计算机上所有的进程
    bool isStarted;
    foreach (string item in lBProcess.Items)            //遍历用户需要守护的进程列表
    {
        isStarted = false;
        foreach (Process p in processes)                //遍历所有进程
        {
            try
            {
                if (item == p.MainModule.FileName)      //检测进程是否已经开启
                {
                    isStarted = true;
                    break;
                }
            }
            catch { continue; }
        }
        if (!isStarted) Process.Start(item);            //如果需要守护的进程未开启，则启动该进程
    }
}

private void bDelete_Click(object sender, EventArgs e)
{
    if (lBProcess.SelectedItem != null)
        lBProcess.Items.Remove(lBProcess.SelectedItem); //将进程从进程守护列表中删除
}
    }
}

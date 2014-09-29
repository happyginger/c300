using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ComponentBackgroundWorker
{
    public partial class FormBackgroundWorker : Form
    {

        public FormBackgroundWorker()
        {
            InitializeComponent();
        }

private void bWWriter_DoWork(object sender, DoWorkEventArgs e)
{
    FileStream FS = File.OpenWrite("test.txt");         //创建文件
    StreamWriter SW = new StreamWriter(FS);             //创建文本流写入器
    for (int i = 0; i < 100000000; i++)
    {
        if (this.bWWriter.CancellationPending) //判断是否已取消后台操作
        {
            e.Cancel = true;                            //取消操作
            break;
        }
        SW.Write("经典实例300");                         //将文本写入文件中
        if (i % 1000000 == 0)                           //报告文件写入进度
            this.bWWriter.ReportProgress(i / 1000000);
    }
    SW.Close();
    FS.Close();
}
private void bWWriter_ProgressChanged(object sender, ProgressChangedEventArgs e)
{
    this.progressBar1.Value = e.ProgressPercentage;     //在界面上显示进度
}
private void bWWriter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
{
    if (e.Cancelled) MessageBox.Show("文件写入已取消！");
    else MessageBox.Show("文件写入已完成！");
    bStart.Enabled = true;
    bCancel.Enabled = false;
}

private void bStart_Click(object sender, EventArgs e)
{
    bStart.Enabled = false;
    bCancel.Enabled = true;
    bWWriter.RunWorkerAsync();                 //开始执行后台操作
}
private void bCancel_Click(object sender, EventArgs e)
{
    bWWriter.CancelAsync();                    //取消后台操作
}
    }
}

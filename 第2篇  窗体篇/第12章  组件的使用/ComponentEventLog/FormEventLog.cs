using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ComponentEventLog
{
    public partial class FormEventLog : Form
    {
        public FormEventLog()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    if (!EventLog.SourceExists("ClassicExamples"))      //创建新的日志
        EventLog.CreateEventSource("ClassicExamples", "TestLog");
    eventLog1.Source = "ClassicExamples";               //设置日志事件源
    eventLog1.Log = "TestLog";                          //设置日志名称
    eventLog1.MachineName = ".";                        //设置计算机名
}

private void bWrite_Click(object sender, EventArgs e)
{
    if (tBLog.Text != string.Empty && EventLog.Exists("TestLog"))
    {
        eventLog1.WriteEntry(tBLog.Text);               //写入日志
        MessageBox.Show("成功写入日志");
        tBLog.Text = string.Empty;
    }
}

private void bRead_Click(object sender, EventArgs e)
{
    lBLog.Items.Clear();
    foreach (EventLogEntry item in eventLog1.Entries)   //读取日志
    {
        lBLog.Items.Add(item.Message);                  //将日志写入ListBox控件中
    }
}
    }
}

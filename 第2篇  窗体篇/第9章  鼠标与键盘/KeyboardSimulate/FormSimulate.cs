using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KeyboardSimulate
{
    public partial class FormSimulate : Form
    {
        public FormSimulate()
        {
            InitializeComponent();
        }

private void bNormal_Click(object sender, EventArgs e)
{
    textBox1.Focus();                                   //使文本框获取焦点
    SendKeys.Send("300 Classic Examples");              //模拟键盘输入字符
    SendKeys.Flush();                                   //处理所有Windows消息
}
private void bSpacial_Click(object sender, EventArgs e)
{
    textBox1.Focus();                                   //使文本框获取焦点
    SendKeys.Send("{BACKSPACE}");                       //模拟键盘输入Backspace键
    SendKeys.Flush();                                   //处理所有Windows消息
}
private void bRepeat_Click(object sender, EventArgs e)
{
    textBox1.Focus();                                   //使文本框获取焦点
    textBox1.Text = string.Empty;                       //消除文本框中的文本
    SendKeys.Send("{A 40}");                            //模拟键盘输入40个A
    SendKeys.Flush();                                   //处理所有Windows消息
}
private void bCombine_Click(object sender, EventArgs e)
{
    SendKeys.Send("%{F4}");  //模拟键盘输入Alt+F4键，其中+表示Shift，^表示Ctrl，%表示Alt
    SendKeys.Flush();                                   //处理所有Windows消息
}

        protected override void OnClosing(CancelEventArgs e)
        {
            MessageBox.Show("程序即将关闭！");
        }


        Stopwatch s = new Stopwatch();
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (!s.IsRunning) s.Start();
            else
            {
                s.Stop();
                Debug.WriteLine(s.ElapsedMilliseconds);
                s.Restart();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!s.IsRunning) s.Start();
            else
            {
                s.Stop();
                Debug.WriteLine(s.ElapsedMilliseconds);
                s.Restart();
            }
        }
    }
}

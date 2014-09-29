using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class Form1 : Form
    {
public Form1()
{
    InitializeComponent();
}

private void bEnter_Click(object sender, EventArgs e)
{
    try
    {
        if (!cBUrl.Text.StartsWith("http://")) cBUrl.Text = "http://" + cBUrl.Text;
        wBSimple.Url = new Uri(cBUrl.Text);             //设置网页浏览器网址
        cBUrl.Items.Add(cBUrl.Text);                    //将网址添加到下拉列表框中
    }
    catch (Exception Ex)
    {
        MessageBox.Show(Ex.Message);
    }
}

private void bGoBack_Click(object sender, EventArgs e)
{
    if (wBSimple.CanGoBack) wBSimple.GoBack();          //网页后退
}

private void bGoForward_Click(object sender, EventArgs e)
{
    if (wBSimple.CanGoForward) wBSimple.GoForward();    //网页前进
}

private void bHomepage_Click(object sender, EventArgs e)
{
    wBSimple.GoHome();                                  //打开主页
}
    }
}

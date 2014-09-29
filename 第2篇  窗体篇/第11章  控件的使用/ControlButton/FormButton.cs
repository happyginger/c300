using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlButton
{
    public partial class FormButton : Form
    {
        int count = 1;              //记录按钮数量
        public FormButton()
        {
            InitializeComponent();
        }

private void bAdd_Click(object sender, EventArgs e)
{
    Button button = sender as Button;                   //获取发出Click事件的按钮
    Button newButton = new Button();                    //创建一个新的按钮
    newButton.Text = "添加按钮";                         //设置新按钮的文本
    newButton.Size = button.Size;                       //设置新按钮的大小
    int row = this.ClientSize.Width / button.Width;     //计算每行放置按钮数量
    newButton.Left = (count % row) * button.Width;      //设置新按钮的左边距
    newButton.Top = (count / row) * button.Height;      //设置新按钮的上边距
    newButton.Click += new EventHandler(bAdd_Click);    //为新按钮添加Click事件
    count++;                                            //增加按钮数量
    this.Controls.Add(newButton);                       //将新按钮动态添加到窗体中
}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseLongDown
{
    public partial class FormMouseLongDown : Form
    {
Timer timer = new Timer();                              //计时器
int timeout = 0;                                        //超时时间
MouseEventArgs mouseDown;                               //鼠标长时按下事件参数
public FormMouseLongDown()
{
    InitializeComponent();
    timer.Interval = 1000;                              //计时器时间间隔
    timer.Tick += new EventHandler(timer_Tick);         //计时器事件发生函数
}

void timer_Tick(object sender, EventArgs e)
{
    if (++timeout == 3)                                 //当鼠标按下3秒时发生
        OnMouseLongDown(this.mouseDown);                //调用鼠标长时按下事件
}

protected override void OnMouseDown(MouseEventArgs e)
{
    this.mouseDown = e;                                 //鼠标按下事件参数
    timeout = 0;                                        //超时时间设置为0
    timer.Start();                                      //启动计时器
}
protected override void OnMouseUp(MouseEventArgs e)
{
    timer.Stop();                                       //停止计时器
}

//定义鼠标长时间按下事件函数
protected virtual void OnMouseLongDown(MouseEventArgs e)
{
    MessageBox.Show("鼠标被长时间按下!");
}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class FormMove : Form
    {
Queue<Point> pointsMouse = new Queue<Point>();          //保存鼠标轨迹
bool isCtrlDown = false;                                //标记Ctrl键是否被按下
        public FormMove()
        {
            InitializeComponent();
        }

private void timer_Tick(object sender, EventArgs e)
{
    if (isCtrlDown) pointsMouse.Enqueue(Cursor.Position);//当Ctrl键被按下
    else if (pointsMouse.Count > 0)                     //当鼠标轨迹数大于0
    {
        Cursor.Position = pointsMouse.Dequeue();        //从轨迹中取出一个点设置为鼠标当前值
        Graphics g = this.CreateGraphics();             //获取窗体绘图表面
        Cursor.Draw(g, new Rectangle(PointToClient(Cursor.Position), Cursor.Size));//在鼠标的当前位置绘制鼠标图标
        g.Dispose();
    }
    else timer.Stop();                                   //停止录像或回放
}

protected override void OnKeyDown(KeyEventArgs e)
{
    if (e.KeyData == (Keys.LButton | Keys.ShiftKey | Keys.Control))
    {//当Ctrl键被按下
        isCtrlDown = true;                              //标记Ctrl键被按下
        timer.Start();                                  //启动计时器
    }
}
protected override void OnKeyUp(KeyEventArgs e)
{
    if (e.KeyData == (Keys.LButton | Keys.ShiftKey))    //Ctrl键被抬起
        isCtrlDown = false;                             //标记Ctrl键被抬起
}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormMdi
{
    public partial class FormMdi : Form
    {
        public FormMdi()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    base.OnLoad(e);

    foreach (var item in this.Controls)                 //遍历所有的窗体控件
    {
        if (item is MdiClient)                          //判断控件是否为MdiClient类型
        {
            MdiClient mdi = item as MdiClient;          //将控件转换为MdiClient类型
            mdi.Click += new EventHandler(mdi_Click);   //为MidClient控件添加Click事件
            break;
        }
    }
}

void mdi_Click(object sender, EventArgs e)
{
    Form form = new Form();                             //创建窗体实例
    form.MdiParent = this;                              //将创建的窗体设置为Mdi子窗体
    form.Text = "MDI子窗体";
    form.Show();                                        //在MdiClient控件中显示子窗体

    form.Click += new EventHandler(form_Click);
}

void form_Click(object sender, EventArgs e)
{
    Form form = (sender as Form);
    if (form.MdiParent == null) form.MdiParent = this;
    else form.MdiParent = null;
}

    }
}

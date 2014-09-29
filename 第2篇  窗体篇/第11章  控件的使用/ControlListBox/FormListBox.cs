using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlListBox
{
    public partial class FormListBox : Form
    {
        public FormListBox()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    listBox1.Items.AddRange(new object[]{"张三", "李四", "王五", "赵六", "孙七", "周八", "吴九", "郑十"});              //向listBox1中添加学生姓名
}

private void bAdd_Click(object sender, EventArgs e)
{
    while (listBox1.SelectedItems.Count > 0)
    {
        listBox2.Items.Add(listBox1.SelectedItems[0]);  //向listBox2中添加数据
        listBox1.Items.Remove(listBox1.SelectedItems[0]);//从listBox1中删除数据
    }
}
private void bRemove_Click(object sender, EventArgs e)
{
    while (listBox2.SelectedItems.Count > 0)
    {
        listBox1.Items.Add(listBox2.SelectedItems[0]);  //向listBox1中添加数据
        listBox2.Items.Remove(listBox2.SelectedItems[0]);//从listBox2中删除数据
    }
}
    }
}

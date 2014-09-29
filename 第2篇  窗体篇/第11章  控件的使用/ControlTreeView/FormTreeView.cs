using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace FormTreeView
{
    public partial class FormTreeView : Form
    {
        public FormTreeView()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    TreeNode computer = tVComputer.Nodes.Add("计算机");  //为TreeView添加根节点
    foreach (var item in Directory.GetLogicalDrives())
    {
        computer.Nodes.Add(item);                       //添加磁盘目录节点
    }
}

private void tVComputer_AfterExpand(object sender, TreeViewEventArgs e)
{
    foreach (TreeNode Node in e.Node.Nodes)             //遍历子节点
    {
        if (Node.Nodes.Count == 0)
        {
            string path = Node.FullPath.Remove(0, 4);   //获取全路径
            DirectoryInfo dir = new DirectoryInfo(path);//创建路径信息对象
            try
            {
                foreach (var folder in dir.GetDirectories())//遍历子目录
                {
                    Node.Nodes.Add(folder.Name);        //将子目录添加到子节点
                }
            }
            catch { continue; }
                    
        }
    }
}
    }
}

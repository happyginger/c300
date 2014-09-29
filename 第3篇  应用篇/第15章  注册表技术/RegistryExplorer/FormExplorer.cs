using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegistryExplorer
{
    public partial class FormExplorer : Form
    {
        public FormExplorer()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    base.OnLoad(e);
    //获取注册表当前用户基项的子项，将其加入树形控件根结点
    GetSubKey(tVRegistryExplorer.Nodes, Registry.CurrentUser);
    //遍历树形控件根结点
    foreach (TreeNode node in tVRegistryExplorer.Nodes)
    {
        //获取根结点所对应注册表项的子项，将其加入树形控件根结点的子节点中
        GetSubKey(node.Nodes, node.Tag as RegistryKey);
    }
}

private void tVRegistryExplorer_AfterExpand(object sender, TreeViewEventArgs e)
{
    //遍历展开节点的子节点
    foreach (TreeNode node in e.Node.Nodes)
    {
        ////获取展开节点的子节点所对应注册表项的子项，将其加入树形控件展开结点的子节点中
        GetSubKey(node.Nodes, node.Tag as RegistryKey);
    }
}

/// <summary>
/// 获取注册表项的子节点，并将其添加到树形控件节点中
/// </summary>
/// <param name="nodes"></param>
/// <param name="rootKey"></param>
public void GetSubKey(TreeNodeCollection nodes, RegistryKey rootKey)
{
    if (nodes.Count != 0) return;
    //获取项的子项名称列表
    string[] keyNames = rootKey.GetSubKeyNames();
    //遍历子项名称
    foreach (string keyName in keyNames)
    {
        try
        {
            //根据子项名称功能注册表项
            RegistryKey key = rootKey.OpenSubKey(keyName);
            //如果表项不存在，则继续遍历下一表项
            if (key == null) continue;
            //根据子项名称创建对应树形控件节点
            TreeNode TNRoot = new TreeNode(keyName);
            //将注册表项与树形控件节点绑定在一起
            TNRoot.Tag = key;
            //向树形控件中添加节点
            nodes.Add(TNRoot);
        }
        catch
        {
            //如果由于权限问题无法访问子项，则继续搜索下一子项
            continue;
        }
    }
}
    }
}

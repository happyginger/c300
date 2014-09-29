using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace AssemblyExplorer
{
    public partial class FormAssemblyExplorer : Form
    {
        public FormAssemblyExplorer()
        {
            InitializeComponent();
        }

private void TSMIOpen_Click(object sender, EventArgs e)
{
    oFDOpen.ShowDialog();
}

        private void oFDOpen_FileOk(object sender, CancelEventArgs e)
        {
Assembly assembly = Assembly.LoadFile(oFDOpen.FileName);//加载程序集
TreeNode TNAssembly = new TreeNode(oFDOpen.FileName);   //以程序集全路径作为根节点
this.tVClass.Nodes.Add(TNAssembly);
foreach (var type in assembly.GetTypes())               //获取程序集中所有类型
{
    TreeNode TNType = TNAssembly.Nodes.Add(type.Name);  //将类型名作为1级节点
    TreeNode TNMember = TNType.Nodes.Add("成员");
    foreach (var member in type.GetMembers())           //获取类型中所有成员
    {
        TNMember.Nodes.Add(member.Name);
    }
    TreeNode TNMethod = TNType.Nodes.Add("方法");
    foreach (var method in type.GetMethods())           //获取类型中所有方法
    {
        TNMethod.Nodes.Add(method.Name);
    }
    TreeNode TNProperty = TNType.Nodes.Add("属性");
    foreach (var property in type.GetProperties())      //获取类型中所有属性
    {
        TNProperty.Nodes.Add(property.Name);
    }
    TreeNode TNField = TNType.Nodes.Add("字段");
    foreach (var field in type.GetFields())             //获取类型中所有字段
    {
        TNField.Nodes.Add(field.Name);
    }
    TreeNode TNEvent = TNType.Nodes.Add("事件");
    foreach (var Event in type.GetEvents())             //获取类型中所有事件
    {
        TNEvent.Nodes.Add(Event.Name);
    }
}

        }
    }
}

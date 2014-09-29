using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.ServiceProcess;

namespace ServiceManager
{
    public partial class FormServiceManager : Form
    {
public FormServiceManager()
{
    InitializeComponent();
}

protected override void OnLoad(EventArgs e)
{
    base.OnLoad(e);

    GetService();
}

private void GetService()
{
    lVService.Items.Clear();
    //获取本地计算机所有服务
    ServiceController[] services = ServiceController.GetServices(".");
    foreach (ServiceController s in services)           //遍历所有服务
    {
        ListViewItem item = lVService.Items.Add(s.ServiceName);
        item.SubItems.Add(s.DisplayName);               //将服务名称添加到列表视图
        item.SubItems.Add(s.Status.ToString());         //将服务状态添加到列表视图
        item.SubItems.Add(s.ServiceType.ToString());    //将服务类型添加到列表视图
    }
}
    }
}

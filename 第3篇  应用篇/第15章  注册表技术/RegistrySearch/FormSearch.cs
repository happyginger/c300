using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegistrySearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void bSearch_Click(object sender, EventArgs e)
{
    //判断后台搜索是否正在进行
    if (!bWSearch.IsBusy)
    {
        //清空搜索结果列表
        lBSearchResult.Items.Clear();
        //对注册表当前用户基项进行搜索
        bWSearch.RunWorkerAsync(Registry.CurrentUser);
    }
    else
    {//提示用户正在搜索
        MessageBox.Show("正在搜索,请稍等...");
    }
}

//搜索注册表委托
delegate void SearchRegistryKeyCallback(RegistryKey key);
/// 搜索注册表指定项
/// <param name="key">注册表项</param>
private void SearchRegistryKey(RegistryKey key)
{
    if (key == null) return;    //判断项是否为空
    //获取注册表项的键名列表
    string[] valueNames = key.GetValueNames();
    //将注册表项加入到搜索状态提示中
    SetSearchState(key.ToString());
    //遍历所有键名，判断键名或键值中是否含有搜索的关键字
    foreach (string valueName in valueNames)
    {
        //搜索的关键字
        string keywords = tBKeywords.Text;
        //获取键值并转换成字符串类型
        string value = key.GetValue(valueName).ToString();
        //判断键名或键值中是否含有搜索的关键字
        if (valueName.Contains(keywords)
            || value.Contains(keywords))
        {//如果含有搜索关键字
            //将该键在注册表中的全路径添加到搜索结果列表中
            AddSearchState(key.ToString() + "\\" + valueName);
        }
    }
    //获取项的所有子项名
    string[] subKeyNames = key.GetSubKeyNames();
    //遍历所有子项，并对其进行搜索
    foreach (string subKeyName in subKeyNames)
    {
        try
        {
            //根据子项名获取子项
            RegistryKey subKey = key.OpenSubKey(subKeyName);
            //如果子项为空，则继续搜索下一子项
            if (subKey == null) continue;
            //搜索子项
            SearchRegistryKey(subKey);
        }
        catch (Exception)
        {
            //如果由于权限问题无法访问子项，则继续搜索下一子项
            continue;
        }
    }
    key.Close();
}
delegate void SetSearchStateCallback(string key);//设置搜索状态委托
void SetSearchState(string key)
{
    if (this.InvokeRequired)
    //如果需要委托调用，则使用设置搜索状态委托
        this.Invoke(new SetSearchStateCallback(SetSearchState), new object[] { key });
    else
        tSSLSearching.Text = key;       //设置搜索状态
}

delegate void AddSearchStateCallback(string key);//添加搜索记录委托
void AddSearchState(string key)
{
    if (this.InvokeRequired)
        //如果需要委托调用，则使用添加搜索记录委托
        this.Invoke(new AddSearchStateCallback(AddSearchState), new object[] { key });
    else
        lBSearchResult.Items.Add(key);  //添加搜索记录
}

private void bWSearch_DoWork(object sender, DoWorkEventArgs e)
{
    //后台搜索注册表项
    this.SearchRegistryKey(e.Argument as RegistryKey);
}

private void bWSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
{
    //提示用户搜索已完成，并显示搜索的总记录数
    MessageBox.Show("搜索完成!共有" + lBSearchResult.Items.Count + "条记录");
}
    }
}

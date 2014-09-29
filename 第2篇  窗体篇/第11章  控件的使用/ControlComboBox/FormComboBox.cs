using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlComboBox
{
    public partial class FormComboBox : Form
    {
Dictionary<string, List<string>> ProvinceCity = new Dictionary<string, List<string>>();
        public FormComboBox()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    ProvinceCity.Add("河北", new List<string>());       //添加省份
    ProvinceCity["河北"].Add("石家庄");                  //添加城市
    ProvinceCity["河北"].Add("唐山");                    //添加城市
    ProvinceCity["河北"].Add("秦皇岛");                  //添加城市
    ProvinceCity.Add("江苏", new List<string>());       //添加省份
    ProvinceCity["江苏"].Add("南京");                   //添加城市
    ProvinceCity["江苏"].Add("无锡");                   //添加城市
    ProvinceCity["江苏"].Add("徐州");                   //添加城市
    ProvinceCity.Add("湖北", new List<string>());       //添加省份
    ProvinceCity["湖北"].Add("武汉");                   //添加城市
    ProvinceCity["湖北"].Add("黄石");                   //添加城市
    ProvinceCity["湖北"].Add("襄樊");                   //添加城市
    foreach (string Province in ProvinceCity.Keys)
    {
        cBProvince.Items.Add(Province);                 //将省份添加到ComboBox控件中
    }
}

private void cBProvince_SelectedIndexChanged(object sender, EventArgs e)
{
    if (cBProvince.SelectedItem != null)
    {
        cBCity.Items.Clear();                           //清空Combo控件中的元素列表
        foreach (string city in ProvinceCity[cBProvince.SelectedItem.ToString()])
        {
            cBCity.Items.Add(city);                     //将省份所包含的城市添加到城市下拉列表框中
        }
        cBCity.SelectedIndex = 0;                       //选择第一个城市
    }
}
    }
}

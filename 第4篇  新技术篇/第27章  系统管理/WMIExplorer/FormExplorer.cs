using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Management;

namespace WMIExplorer
{
    public partial class FormExplorer : Form
    {
        List<string> managementObjects = new List<string>();
        public FormExplorer()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var allManagementObjects = this.GetAllManagementObject();

            foreach (var MO in allManagementObjects) managementObjects.Add(MO.ClassPath.RelativePath.ToString());
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            var allManagementObjects = managementObjects
                .Where(MO => MO.StartsWith("Win32"))
                .OrderBy(MO => MO);
            //listBox1.Items.AddRange(allManagementObjects.ToArray());
            foreach (var MO in allManagementObjects)
            {
                listBox1.Items.Add(MO);
                Application.DoEvents();
            }
        }

        private PropertyDataCollection GetPropertyDatas(string path)
        {
            return new ManagementClass(path).Properties;
        }

        private ManagementObjectCollection GetPahtManagementObject(string path)
        {
            return new ManagementClass(path).GetInstances();
        }

        private ManagementObjectCollection GetAllManagementObject()
        {
            //每个WMI类是meta_class的实例
            return new ManagementObjectSearcher("SELECT * FROM meta_class").Get();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 || listBox1.SelectedIndex == -1) return;

            listBox2.Items.Clear();

            foreach (var item in GetPropertyDatas(listBox1.SelectedItem.ToString()))
            {
                listBox2.Items.Add(item.Name);
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0 || listBox2.SelectedIndex == -1) return;
            listBox3.Items.Clear();
            try
            {
                var managementObjects = this.GetPahtManagementObject(listBox1.SelectedItem.ToString());
                foreach (var propertyData in managementObjects)
                {
                    listBox3.Items.Add(propertyData[listBox2.SelectedItem.ToString()].ToString());
                    Application.DoEvents();
                }
            }
            catch { }
            
        }
    }
}

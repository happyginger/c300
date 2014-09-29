using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfStudentTemplate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

public class Students : ObservableCollection<Student>
{
    public Students()
    {
        this.Add(new Student() { Name = "张三", Age = 18, Sex = "男", Grade = 1 });
        this.Add(new Student() { Name = "李四", Age = 21, Sex = "女", Grade = 4 });
        this.Add(new Student() { Name = "王五", Age = 20, Sex = "男", Grade = 3 });
        this.Add(new Student() { Name = "赵六", Age = 19, Sex = "女", Grade = 2 });
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public int Grade { get; set; }
    public override string ToString()
    {
        return String.Format("{0}\t{1}岁\t{2}\t{3}年级", 
            this.Name, this.Age, this.Sex, this.Grade);
    }
}
}

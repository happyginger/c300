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
using System.Diagnostics;
using System.ComponentModel;

namespace ClickButtonHideWindow
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> personList = new ObservableCollection<Person>();

        public ObservableCollection<Person> PersonList
        {
            get { return personList; }
            set { personList = value; }
        }

        public MainWindow()
        {
            //初始化
            this.Initialized += (sender, e) =>
            {
                Debug.WriteLine("窗体初始化完成 Initialized");
            };
            InitializeComponent();

            

            //激活
            this.Activated += (sender, e) =>
            {
                Debug.WriteLine("窗体被激活 Activated");
            };

            //加载
            this.Loaded += (sender, e) =>
            {
                Debug.WriteLine("窗体加载完成 Loaded");
            };

            //呈现内容
            this.ContentRendered += (sender, e) =>
            {
                Debug.WriteLine("呈现内容 ContentRendered");
            };

            //失活
            this.Deactivated += (sender, e) =>
            {
                Debug.WriteLine("窗体被失活 Deactivated");
            };

            //窗体获取输入焦点
            this.GotFocus += (sender, e) =>
            {
                Debug.WriteLine("窗体获取输入焦点 GotFocus");
            };

            //窗体失去输入焦点
            this.LostFocus += (sender, e) =>
            {
                Debug.WriteLine("窗体失去输入焦点 LostFocus");
            };

            //键盘获取输入焦点
            this.GotKeyboardFocus += (sender, e) =>
            {
                Debug.WriteLine("键盘获取输入焦点 GotKeyboardFocus");
            };

            //键盘失去输入焦点
            this.LostKeyboardFocus += (sender, e) =>
            {
                Debug.WriteLine("键盘失去输入焦点 LostKeyboardFocus");
            };

            //正在关闭
            this.Closing += (sender, e) =>
            {
                Debug.WriteLine("窗体正在关闭 Closeing");
            };

            //关闭
            this.Closed += (sender, e) =>
            {
                Debug.WriteLine("窗体正在关闭 Closed");
            };

            personList.Add(new Person() { Name = "一线码农", Age = 24 });

            personList.Add(new Person() { Name = "XXX", Age = 21 });

            List<Student> list = new List<Student>();

            for (int i = 20; i < 30; i++)
            {
                list.Add(new Student() { Name = "hxc" + i, Age = i });
                personList.Add(new Person() { Name = "hxc" + i, Age = i });
            }

            listView1.ItemsSource = list;
            listview2.ItemsSource = personList;
            textBox2.Text = "1";

            for (int i = 0; i < 100; i++)
            {
                TextBox tbx = new TextBox();

                tbx.Text = i.ToString();

                Test.Children.Add(tbx);
            }
        }



        private void bHideWindow_Click(object sender, RoutedEventArgs e)
        {
            //throw new Exception("抛出异常");
            //this.Hide();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            var num = Convert.ToInt32(textBox2.Text);

            textBox2.Text = (++num).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            personList.RemoveAt(0);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
             var first = personList.FirstOrDefault();

             first.Name = textbox1.Text;
        }

        private void Ellipse_MouseUp(object sender, MouseButtonEventArgs e)
        {
        }
    }
    public class ColorConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //这里的value既为当前的行对象
            var item = value as ListViewItem;

            //获取当前的item在当前的Listview中的位置
            var view = ItemsControl.ItemsControlFromItemContainer(item) as ListView;

            var index = view.ItemContainerGenerator.IndexFromContainer(item);

            //当Age=22是红色标示
            if ((view.Items[index] as Student).Age == 22)
                return Brushes.Red;

            if (index % 2 == 0)
                return Brushes.Pink;
            else
                return Brushes.Blue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }


    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string GetName() { return "哈哈哈哈"; }
    }

    public class Person : INotifyPropertyChanged
    {
        public string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChange("Name");
            }
        }

        public int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                NotifyPropertyChange("Age");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class NameCheck : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            var name = Convert.ToString(value);

            //如果名字长度大于4则是非法
            if (name.Length > 4)
                return new ValidationResult(false, "名字长度不能大于4个长度！");

            return ValidationResult.ValidResult;
        }
    }

    public class CustomTextBlock : TextBlock
    {
        //自定义一个依赖项属性
        public static DependencyProperty TimeProperty = DependencyProperty.Register("Timer", typeof(DateTime), typeof(CustomTextBlock), new PropertyMetadata(DateTime.Now, OnTimerPropertyChanged), ValidateTimeValue);
        /// <summary>
        /// 对依赖属性进行设置值
        /// </summary>
        public DateTime Time
        {
            get
            {
                //获取当前属性值 
                return (DateTime)GetValue(TimeProperty);
            }
            set
            {
                //给当前的属性赋值
                SetValue(TimeProperty, value);
            }
        }


        static void OnTimerPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {

        }

        static bool ValidateTimeValue(object obj)
        {
            DateTime dt = (DateTime)obj;

            if (dt.Year > 1990 && dt.Year < 2200)
                return true;
            return false;
        }

    }

}

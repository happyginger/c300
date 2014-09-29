using System.Windows.Forms;                             //.Net窗体命名空间
using ClassLibrary;                                     //引用ClassLibrary命名空间
namespace WindowsFormsApplication                       //本窗体应用程序命名空间
{
    public partial class Form1 : Form                   //定义窗体类Form1，该类继承Form类
    {
public Form1()                                          //Form1窗体构造函数
{
    InitializeComponent();                              //窗体初始化函数
    MyClass myClass = new MyClass();                    //实例化MyClass类
    myClass.HelloWorld();                               //调用MyClass类的HelloWorld方法
}
    }
}

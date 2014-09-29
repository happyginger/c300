using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateStudentList
{
//学生结构体
struct Student
{
    static readonly string[] surnames = new string[]    //初始化姓数组
        { "郑", "胡", "张", "李", "王", "赵", "周", "刘", "钱", "孙" };
    static readonly string[] names = new string[]       //初始化名数组
        { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十" };
    readonly int _grade;                    //年级
    public int Grade { get { return _grade; } }
    readonly decimal _number;               //学号
    public decimal Number { get { return _number; } }
    readonly string _name;                  //姓名
    public string Name { get { return _name; } }
    readonly string _sex;                   //性别
    public string Sex { get { return _sex; } }
    readonly int _age;                      //年龄
    public int Age { get { return _age; } }
    readonly int _result;                   //成绩
    public int Result { get { return _result; } }
    /// <summary>学生类构造函数</summary>
    /// <param name="grade">年级</param>
    /// <param name="number">学号</param>
    /// <param name="name">姓名</param>
    /// <param name="sex">性别</param>
    /// <param name="age">年龄</param>
    /// <param name="result">//成绩</param>
    public Student(int grade, decimal number, string name, string sex, int age, int result)
    {
        this._grade = grade;
        this._number = number;
        this._name = name;
        this._sex = sex;
        this._age = age;
        this._result = result;
    }
    /// 重载ToString()函数
    /// <returns>学生信息字符串</returns>
    public override string ToString()
    {
        return string.Format("{0}  {1}年级  {2}  {3}  {4,3}岁 {5,3}分",
            _number, _grade, _name, _sex, _age, _result);
    }
    /// 获取学生信息列表
    /// <param name="count">信息数量</param>
    /// <returns>学生信息列表</returns>
    public static Student[] GetStudents(int count)
    {
        int number = 20120000;              //起始学号
        Random r = new Random();            //伪随机数生成器
        Student[] sts = new Student[count]; //创建学生信息列表
        for (int i = 0; i < 20; i++)        //随机生成学生信息
        {
            sts[i] = new Student(
            r.Next(1, 5),                   //1到4之间随机年级
            number++,                       //从起始值开始自增
            surnames[r.Next(surnames.Length)] + names[r.Next(names.Length)],//随机姓名
            r.Next(2) == 0 ? "男" : "女",    //男或女随机性别
            r.Next(16, 24),                 //16到23之间随机年龄
            r.Next(101));                   //0到100之间随机成绩
        }
        return sts;                         //返回学生信息列表
    }
}
}

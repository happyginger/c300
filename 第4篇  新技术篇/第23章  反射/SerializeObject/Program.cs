using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;



namespace SerializeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "序列化存取类实例";

Program p = new Program();
Student student = new Student("张三", 20, "男", 3);
student.Interests.Add(new Interest("篮球"));
student.Interests.Add(new Interest("游泳"));
Console.WriteLine("二进制序列化学生类：");
Console.Write("姓名：{0} 年龄：{1} 性别 {2} 年级 {3} 爱好有：",
    student.Name, student.Age, student.Sex, student.Grade);
foreach (var item in student.Interests) Console.Write(item.Name + " ");
p.BinarySerializeStudent(student);
Console.WriteLine("\n二进制反序列化学生类：");
student = p.BinaryDeserializeStudent();
Console.Write("姓名：{0} 年龄：{1} 性别 {2} 年级 {3} 爱好有：",
    student.Name, student.Age, student.Sex, student.Grade);
foreach (var item in student.Interests) Console.Write(item.Name + " ");
Console.WriteLine("\nXml序列化学生类：");
Console.Write("姓名：{0} 年龄：{1} 性别 {2} 年级 {3} 爱好有：",
    student.Name, student.Age, student.Sex, student.Grade);
foreach (var item in student.Interests) Console.Write(item.Name + " ");
p.XmlSerializeStudent(student);
Console.WriteLine("\nXml反序列化学生类：");
student = p.XmlDeserializeStudent();
Console.Write("姓名：{0} 年龄：{1} 性别 {2} 年级 {3} 爱好有：",
    student.Name, student.Age, student.Sex, student.Grade);
foreach (var item in student.Interests) Console.Write(item.Name + " ");

            Console.Read();
        }

public void BinarySerializeStudent(Student student)
{
    //创建一个文件用来存储序列化后的学生类
    FileStream studentStream = new FileStream("student.dat", FileMode.Create);
    BinaryFormatter formatter = new BinaryFormatter();     //二进制格式化器
    formatter.Serialize(studentStream, student);           //将学生类实例序列化后存入文件中
    studentStream.Close();
}

public Student BinaryDeserializeStudent()
{
    //打开学生类实例二进制序列化后存放的文件
    FileStream studentStream = new FileStream("student.dat", FileMode.Open, FileAccess.Read);
    BinaryFormatter formatter = new BinaryFormatter();      //二进制格式化器
    //从文件流中反序列化学生类实例
    Student student = formatter.Deserialize(studentStream) as Student;
    studentStream.Close();
    return student;
}

/*  1. 需要序列化为xml元素的属性必须为读/写属性；
    2. 注意为类成员设定缺省值，尽管这并不是必须的。
    使用 XmLSerializer 类，可将下列项序列化。
    公共类的公共读／写属性和字段
    实现 ICollection 或 IEnumerable 的类。（注意只有集合会被序列化，而公共属性却不会。）
    XmlElement 对象。
    XmlNode 对象。
    DataSet 对象。
    */
public void XmlSerializeStudent(Student student)
{
    //创建一个文件用来存储序列化后的学生类
    Stream studentStream = new FileStream("student.xml", FileMode.Create);
    XmlSerializer formatter = new XmlSerializer(typeof(Student));//Xml格式化器
    formatter.Serialize(studentStream, student);           //将学生类实例序列化后存入文件中
    studentStream.Close();
}

public Student XmlDeserializeStudent()
{
    //打开学生类实例Xml序列化后存放的文件
    Stream studentStream = new FileStream("student.xml", FileMode.Open);
    XmlSerializer formatter = new XmlSerializer(typeof(Student));//Xml格式化器
    //从文件流中反序列化学生类实例
    Student student = formatter.Deserialize(studentStream) as Student; 
    studentStream.Close();
    return student;
}
    }
}

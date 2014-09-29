using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Collections;

namespace ReflectSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "利用反射读取序列化类";

Assembly myAssembly = Assembly.LoadFile("V:\\SerializeObject.exe");//加载指定路径上的程序集
Type Student = myAssembly.GetType("SerializeObject.Student");//获取程序集中Student类型
Type Interest = myAssembly.GetType("SerializeObject.Interest");
//打开Student类实例二进制序列化后存放的文件
FileStream studentStream = new FileStream("student.xml", FileMode.Open, FileAccess.Read);
XmlSerializer formatter = new XmlSerializer(Student);       //Xml格式化器
object student = formatter.Deserialize(studentStream);//从文件流中反序列化Student类实例

PropertyInfo nameInfo = Student.GetProperty("Name");        //获取姓名属性信息
PropertyInfo ageInfo = Student.GetProperty("Age");          //获取年龄属性信息
PropertyInfo gradeInfo = Student.GetProperty("Grade");      //获取年级属性信息
PropertyInfo sexInfo = Student.GetProperty("Sex");          //获取性别属性信息
PropertyInfo interestsInfo = Student.GetProperty("Interests");//获取兴趣列表属性信息
string name = string.Empty, sex = string.Empty;
object interests;
int age = 0, grade = 0;
if (nameInfo != null) name = nameInfo.GetValue(student, null) as string;//反射获取姓名
if (ageInfo != null) age = (int)ageInfo.GetValue(student, null);//反射获取年龄
if (sexInfo != null) sex = sexInfo.GetValue(student, null) as string;//反射获取年级
if (gradeInfo != null) grade = (int)gradeInfo.GetValue(student, null);//反射获取性别
Console.WriteLine("姓名：{0} 年龄：{1} 性别 {2} 年级 {3}", name, age, sex, grade);
PropertyInfo nameInterestInfo = Interest.GetProperty("Name");
if (interestsInfo != null && interestsInfo.GetValue(student, null) != null)
{
    interests = interestsInfo.GetValue(student, null);      //反射获取兴趣列表
    Console.Write("方法一获取爱好有：");
    //反射获取兴趣列表数量
    int count = (int)interests.GetType().GetProperty("Count").GetValue(interests, null);
    for (int i = 0; i < count; i++)
    {
        //反射获取兴趣列表指定索引兴趣类型实例
        object interest = interests.GetType().GetMethod("get_Item").Invoke(interests, new object[] { i });
        if (nameInterestInfo == null) break;
        //反射获取兴趣名称
        string nameInterest = nameInterestInfo.GetValue(interest, null) as string;
        Console.Write(nameInterest + " ");
    }
    Console.Write("\n方法二获取爱好有：");
    //反射获取兴趣列表枚举器
    IEnumerator enumerator = interests.GetType().GetMethod("GetEnumerator").Invoke(interests, null) as IEnumerator;
    while (enumerator.MoveNext())
    {
        object interest = enumerator.Current;//获取兴趣类型实例
        if (nameInterestInfo == null) break;
        //反射获取兴趣名称
        string nameInterest = nameInterestInfo.GetValue(interest, null) as string;
        Console.Write(nameInterest + " ");
    }
}

            Console.Read();
        }
    }
}

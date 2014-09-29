using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace CreateXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "创建XML文档";

XmlDocument xmlDoc = new XmlDocument();                 //Xml文档对象
XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);//创建Xml声明
xmlDoc.AppendChild(xmlDec);                             //将声明添加到Xml文件的起始位置
XmlElement section1 = xmlDoc.CreateElement("基础篇");      //创建根元素
xmlDoc.AppendChild(section1);                           //添加根元素

XmlNode chapter1 = xmlDoc.CreateElement("开发环境");        //创建二级节点
section1.AppendChild(chapter1);                         //在根元素下添加二级节点
XmlNode chapter2 = xmlDoc.CreateElement("语法基础");    //创建二级节点
section1.AppendChild(chapter2);                         //在根元素下添加二级节点

XmlElement example1 = xmlDoc.CreateElement("创建控制台应用程序");
example1.SetAttribute("ID", "1");                       //为三级元素设置ID属性
example1.InnerText = "介绍在Visual Studio 2010中如何创建控制台应用程序";
chapter1.AppendChild(example1);                         //在二级节点下添加三级元素
XmlElement example2 = xmlDoc.CreateElement("创建Windows窗体应用程序");
example2.SetAttribute("ID", "2");                       //为三级元素设置ID属性
example2.InnerText = "介绍在Visual Studio 2010中如何创建Windwos窗体应用程序";
chapter1.AppendChild(example2);                         //在二级节点下添加三级元素
XmlElement example3 = xmlDoc.CreateElement("从控制台输出整数类型");
example3.SetAttribute("ID", "4");                       //为三级元素设置ID属性
example3.InnerText = "介绍了C#中整数类型的使用方法";
chapter2.AppendChild(example3);                         //在二级节点下添加三级元素
XmlElement example4 = xmlDoc.CreateElement("从控制台输出浮点类型");
example4.SetAttribute("ID", "5");                       //为三级元素设置ID属性
example4.InnerText = "介绍了C#中浮点类型的使用方法";
chapter2.AppendChild(example4);                         //在二级节点下添加三级元素

xmlDoc.Save("300 classic examples.xml");                //保存Xml文档
StreamReader reader = File.OpenText("300 classic examples.xml");//打开Xml文档
Console.Write(reader.ReadToEnd());//输出Xml文档内容
reader.Close();

            Console.ReadLine();
        }
    }
}

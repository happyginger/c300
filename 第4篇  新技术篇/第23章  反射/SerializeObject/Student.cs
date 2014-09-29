using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SerializeObject
{
[Serializable]
[XmlRoot("student")]
public class Student
{
    string name;
    [XmlAttribute(AttributeName = "name")]
    public string Name { get { return name; } set { name = value; } }
    int age;
    //[XmlIgnore]
    [XmlAttribute("age")]
    public int Age { get { return age; } set { age = value; } }
    string sex;
    public string Sex { get { return sex; } set { sex = value; } }
    [NonSerialized]
    public readonly int Grade;
    List<Interest> interests = new List<Interest>();
    [XmlElement("interests")]
    public List<Interest> Interests { get { return interests; } set { interests = value; } }
    public Student() { }
    public Student(string name, int age, string sex, int grade)
    {
        this.name = name;
        this.age = age;
        this.sex = sex;
        this.Grade = grade;
    }
}
}

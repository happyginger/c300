using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SerializeObject
{
[Serializable]
public class Interest
{
    string name;
    [XmlAttribute(AttributeName = "name")]
    public string Name { get { return name; } set { name = value; } }
    public Interest() { }
    public Interest(string name)
    {
        this.name = name;
    }
}
}

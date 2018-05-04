using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace _08_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument myxml = new XmlDocument();
            myxml.Load("XMLFile1.xml");//读取指定的xml文件
            XmlNode engineer = myxml.DocumentElement;//读取xml的根节点
            foreach (XmlNode node in engineer.ChildNodes)//获取子节点进行循环
            {
                //一个node代表一个节点
                //将每个子节点的内容显示出来
                string books = node.Attributes["id"].Value.ToString();
                Console.WriteLine(books);
                Console.WriteLine(node["channelType"].InnerText + "\t" + node["tvChannel"].InnerText + "\t" + node["path"].InnerText);
                Console.WriteLine("============================================================================");
            }            
            Console.ReadKey();
        }
    }   
}

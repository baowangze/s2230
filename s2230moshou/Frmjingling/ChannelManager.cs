
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Frmjingling
{
    /// <summary>
    /// 负责解析名称 为FullChannels.xml
    /// </summary>
    public  class ChannelManager
    {
        //定制一个泛型集合  
        //key 代表的频道名称  value 代表频道对象
        private Dictionary<string, ChannelBase> allChannels = new Dictionary<string, ChannelBase>();

        public Dictionary<string, ChannelBase> AllChannels
        {
            get { return allChannels; }
            set { allChannels = value; }
        }
        /// <summary>
        /// 解析所有电视台并且填充到泛型集合中
        /// </summary>
        public void ResolveAllChannels()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("FullChannels.xml");
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                //一个item就是一个频道
                string type = item["channelType"].InnerText;
                ChannelBase channe1 = ChannelFactory.getInstance(type);
                channe1.channelName = item["tvChannel"].InnerText;
                channe1.path = item["path"].InnerText;
                channe1.Fetch();
                allChannels.Add(channe1.channelName,channe1);
            }
        }
    }
}

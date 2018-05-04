
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Frmjingling
{
    public class TypeBChannel : ChannelBase
    {
        public override void  Fetch()
    {

        XmlDataDocument doc = new XmlDataDocument();
        doc.Load(path);
        XmlNode root = doc.DocumentElement;
        if (programList == null)
        {
            programList = new List<TvProgram>();
        }
        foreach (XmlNode item1 in root.ChildNodes)
        {
            if (item1.Name == "ProgramList")
            {
                foreach (XmlNode child in item1.ChildNodes)
                {
                    //一个child代表一个节目清单
                    TvProgram tv = new TvProgram();
                    tv.FilePath = child["path"].InnerText;
                    
                    tv.PlayTime = Convert.ToDateTime(child["playTime"].InnerText);
                    tv.ProgramName = child["name"].InnerText;
                    programList.Add(tv);

                }
            }

        }
    }
  }
}


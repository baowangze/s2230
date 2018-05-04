using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frmpaty
{
    public class prect
    {
        public string  Name { get; set; }//保存一个歌曲名字
        public string pricurl { get; set; }//保存的歌曲路径 
        public prect(string name , string pricurl)
        {
            this.Name = name;
            this.pricurl = pricurl;
        }
    }
}

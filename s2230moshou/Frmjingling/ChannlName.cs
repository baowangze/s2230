using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frmjingling
{

    //频道的父类
    public abstract class ChannlName
    {
        //频道名称
        public string ChannelName { get; set; }
        //频道路径
        public string Path { get; set; }
        //节目列表，该频道上的所有节目列表
        public List<TvProgram> TvList { get; set; }
        //获取频道列表：通过Fetch方法获取该频道拥有的所有节目列表
        public abstract void Fetch();
    }
}

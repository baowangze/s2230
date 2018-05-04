using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frmjingling
{
    public abstract class ChannelBase
    {
        
        #region 属性
        /// <summary>
        /// 频道名称
        /// </summary>
        public string channelName { get; set; }
        /// <summary>
        /// 频道路径
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// 节目列表
        /// </summary>
        /// 
        //public List<TvProgram> programList;
        public List<TvProgram> programList { get; set; }
         
        #endregion

        public abstract void Fetch();  
    }
}

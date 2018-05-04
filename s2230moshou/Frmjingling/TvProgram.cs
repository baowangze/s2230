using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frmjingling
{
    //节目类
    public class TvProgram
    {
        ////播放时间
        //public DateTime PlayTime { get; set; }
        ////早间当 午间当 晚间档
        //public string ShiDuan { get; set; }
        ////名字
        //public string Name { get; set; }
        ////视频路径
        //public string Path { get; set; }
        #region 属性

        /// <summary>  
        /// 播出时间  
        /// </summary>  
        private DateTime playTime;
        public DateTime PlayTime
        {
            get { return playTime; }
            set { playTime = value; }
        }
        /// <summary>  
        /// 时段  
        /// </summary>  
        private string median;
        public string Median
        {
            get { return median; }
            set { median = value; }
        }
        /// <summary>  
        /// 名称  
        /// </summary>  
        private string programName;
        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }
        /// <summary>  
        /// 文件路径  
        /// </summary>  
        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        #endregion  
    }
}

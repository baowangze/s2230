using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo2
{
   public class Job
    {
        //工作名称
        public string  Name { get; set; }
        //描述
        public string Description { get; set; }
        //构造函数
        public Job(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}

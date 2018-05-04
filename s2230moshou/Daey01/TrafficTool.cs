using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daey01
{
    //里氏替换原则的应用
    //交通工具类
   public class TrafficTool
    {
       public virtual void Run()
       {
           Console.WriteLine("正在奔跑");
       }

    }

}

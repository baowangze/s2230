 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo1
{
   public  class Truck:Vehicle
    {
       //构造函数
       public Truck(string type, string place) : base(type,place) 
       {
       
       }
       public void TruckRun()
       {
           Console.WriteLine(string.Format("型号为{0},产地为{1}的卡车在行驶！！",this.Type,this.Place));
       }
    }
}

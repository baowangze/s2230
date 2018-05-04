using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo1
{
    public  class Vehicle
    {
        //型号
        public string  Type  { get; set; }
        //产地
        public string  Place { get; set; }
        //构造函数
        public Vehicle(string type , string place)
        { 
                this.Type = type;
                this.Place = place;
        }
        //定义一个VehicleRun方法
        public void VehicleRun()
        {
            Console.WriteLine("汽车正在行驶");
        }
    }
}

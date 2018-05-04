using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daey01
{
    //小汽车类
    public class Car:TrafficTool
    {
        public override void Run()
        {
            Console.WriteLine("汽车在行驶");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck("丰田霸道","韩国");
            truck.VehicleRun();
            truck.TruckRun();
            Console.ReadKey();
        }
    }
}

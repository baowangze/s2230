using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FemCar
{
    public class Truck:Abstract
    {
        //载重
        public int Load { get; set; }
        public Truck() { }
        public Truck(string color, double dailyrent, string licenseno, string name, int rentdate, string rentuser, int yearsofservice, int load)
            : base(color, dailyrent, licenseno, name, rentdate, rentuser, yearsofservice)
        {
            this.Load = load;
        }
        //计算价钱
        public override double CalcPrice()
        {
            double totalPrice = 0;
            double basicPrice = this.RentDate * this.DailyRent;
            return totalPrice;
        }
    }
}

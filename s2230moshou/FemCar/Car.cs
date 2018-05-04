using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FemCar
{
    public class Car:Abstract
    {
        public int Load { get; set; }
        public Car()
        {
        }
        public Car(string color, double dailyrent, string licenseno, string name, int rentdate, string rentuser, int yearsofservice)
            : base(color, dailyrent, licenseno, name, rentdate, rentuser, yearsofservice)
        {

        }
        //计算价钱
        public override double CalcPrice()
        {
            double basicPrice = this.RentDate * this.DailyRent;
            return basicPrice;
        }
    }
}

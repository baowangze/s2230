using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FemCar
{
    public abstract  class Abstract
    {
        //颜色
        public string Color { get; set; }
        //日租金
        public double DailyRent { get; set; }
        //车牌号
        public string LicensoNO { get; set; }
        //车名
        public string Name { get; set; }
        //租车日期
        public int RentDate { get; set; }
        //租车人
        public string RentUser { get; set; }
        //使用时间
        public int YearsOfService { get; set; }
        public Abstract() { }
        public Abstract(string color, double dailyrent, string licenseno, string name, int rentdate, string rentuser, int yearsOfService)
        {
            this.Color = color;
            this.DailyRent = dailyrent;
            this.LicensoNO = licenseno;
            this.Name = name;
            this.RentDate = rentdate;
            this.RentUser = rentuser;
            this.YearsOfService = yearsOfService;
        }
        public abstract double CalcPrice();
    }
}

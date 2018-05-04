using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frmtaocan
{
  public  class HealthChectSet
    {
        //套餐名称
      
        public List<HealthCheckItem> items;
        public string  Name { get; set; }
        public int Price { get; set; }
        public HealthChectSet()
        {
            items = new List<HealthCheckItem>();
        }
        public HealthChectSet(string name, List<HealthCheckItem> items)
        {
            this.Name = name;
            this.items = items;
        }
        #region 价格的计算
        //套餐价格计算方法
        public int Calcprice()
        {
            int totalPrice = 0;
            foreach (HealthCheckItem item in items)
            {
                totalPrice += item.Price;
            }
            this.Price = totalPrice;
            return Price;

        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frmtaocan
{
  public  class HealthCheckItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string  Description { get; set; }

        public HealthCheckItem(string name, int price, string description)
        {
            // TODO: Complete member initialization
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }

    }
}

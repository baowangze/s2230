using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmForm
{
    public abstract class clackiet
    {
        private double numLeft;

        private double numRight;
        public abstract double Cale();
        public double NumRight
        {
            get { return numRight; }
            set { numRight = value; }
        }
        public double NumLeft
        {
            get { return numLeft; }
            set { numLeft = value; }
        } 
    }
}

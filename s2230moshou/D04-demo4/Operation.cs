using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo4
{
     public class Operation
    {
        private double NumberA;

        public double NumberA1
        {
            get { return NumberA; }
            set { NumberA = value; }
        }
        private double NumberB;

        public double NumberB1
        {
            get { return NumberB; }
            set { NumberB = value; }
        }
        public virtual double GetResult()
        {
            double rusuit = 0;
            return rusuit;
        }
    }
}

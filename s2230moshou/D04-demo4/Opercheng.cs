using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo4
{
    public class Opercheng:Operation
    {
        public override double GetResult()
        {
            double s = this.NumberA1 * this.NumberB1;
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo4
{
    //实现加法的效果
    public class OperationAdd:Operation
    {
        public override double GetResult()
        {
            double result = this.NumberA1 + this.NumberB1;
            return result;
        }
    }
}

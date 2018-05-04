using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo4
{
    public class OperationDiv:Operation
    {
        public override double GetResult()
        {
            if (NumberB1 == 0)
            {
                throw new Exception("除数不能为0");
            }
            double result = this.NumberA1 / this.NumberB1;
            return result;
        }
    }
}

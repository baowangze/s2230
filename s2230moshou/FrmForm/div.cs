
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmForm
{
    public class div:clackiet
    {
        public override double Cale()
        { 
            if (NumRight == 0)
	    {
		 throw new Exception("除数不能为0");
	    }
            double result = NumLeft / NumRight;
            return result; 
        }
    }
}

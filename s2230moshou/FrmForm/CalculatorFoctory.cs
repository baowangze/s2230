
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmForm
{
    public class CalculatorFoctory
    {
        public static clackiet getInstance (string type)
        {
            clackiet cal = null;
            switch (type)
            {
                case "+":
                    cal = new add();
                    break;
                case "-":
                    cal = new jian();
                    break;
                case "*":
                    cal = new cheng();
                    break;
                case "/":
                    cal = new div();
                    break;
                default:
                    break;
            }
            return cal;
        }
    }
}

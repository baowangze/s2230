using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daey01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee s = new Employee("112", "爱变成", 25, Gender.男, 100);
            s.GoHome(new Car());
            Console.ReadKey();
        }
    }
}

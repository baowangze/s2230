using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMain1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Iflay> List = new List<Iflay>();
            Hello h = new Hello();
            List.Add(h);
            foreach (Hello item in List)
            {
                item.str();
                item.ss(1);
            }
            Console.ReadKey();

        }
    }
}

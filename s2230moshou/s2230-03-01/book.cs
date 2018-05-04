using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2230_03_01
{
    class book
    {
        public string  BookName { get; set; }

        public int  BookAge {get ; set ; }
        public override string ToString()
        {
            return this.BookName;
        }

    }
}

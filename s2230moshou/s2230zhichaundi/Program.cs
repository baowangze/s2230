using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2230zhichaundi
{
    class Program
    {
        static void Main(string[] args)
        {
            SE s = new SE();
            s.Age = 25;
            s.name = "张建";
            s.Popularity = 10;
            Voter voter = new Voter();
            voter.Vote(s);//引用类型做参数
             
        }
    }
}

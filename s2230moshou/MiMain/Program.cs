using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMain
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立部门工程师
            ArrayList list = new ArrayList();
            //初始化三个工程师
            SE jack = new SE();
            jack.Name = "王小毛";
            jack.Age = 26;
            jack.ender = Gender.男.ToString();
            jack.ID = 12;
            jack.Popularity =10 ;
            list.Add(jack);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

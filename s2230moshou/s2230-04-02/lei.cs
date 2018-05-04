using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2230_04_02
{
    class lei
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Year { get; set; }
       public  lei (string id , string name ,int age ,string gender, int year)
        { 
            this.Id=id;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Year = year;
         }
 
    }
}

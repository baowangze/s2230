using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo2
{
   public  class PM:Employee
    {
       public string Dowork()
       {
           string s = ":管理员工完成工作内容！！";
           string message = this.Name+s;
           return message;
       }
       public  PM(string id ,string name , int age,Gender gender,int yearOfExperience,List<Job>list ):base(id,age,name,gender,list)
       {
           this.yearOfExpertion = yearOfExperience;
       }
       private int yearOfExpertion;

       public int YearOfExpertion
       {
           get { return yearOfExpertion; }
           set { yearOfExpertion = value; }
       }
    }

}

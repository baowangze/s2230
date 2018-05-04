using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo2
{
   public  class SE:Employee
    {
       public string DoWork()
       {
           StringBuilder sb = new StringBuilder();
           sb.Append(this.Name+"\n");
           for (int i = 0; i < this.WorkList.Count; i++)
           {
               sb.Append((i+1)+","+WorkList [i].Name + ":"+WorkList[i].Description+"\n");

           }
           return sb.ToString();
       }
       public SE(string id, string name, int age, Gender gender, int populatity, List<Job> list)
           : base(id, age, name, gender, list)
                {
                    this.Populatity = populatity;
                 }
       private int populatity;

       public int Populatity
       {
           get { return populatity; }
           set { populatity = value; }
       }
    }
}

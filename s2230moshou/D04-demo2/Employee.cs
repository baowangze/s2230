using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_demo2
{
   public class Employee
    {
       //年龄
        public int Age { get; set; }
       //性别
        public Gender Gender { get; set; }
       //ID
        public string ID { get; set; }
       //姓名
        public string  Name { get; set; }
       //给Employee类的函数
        public List<Job> WorkList { get; set; }
        public Employee(string id,int age , string name,Gender gender,List<Job>List)
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.WorkList = List;
        }
    }
}

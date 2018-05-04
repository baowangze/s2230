using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daey01
{
    public class Employee
    {
            //员工号
        public string ID { get; set; }
        //姓名
        public string Name { get; set; }
        //年龄
        public int Age { get; set; }
        //性别
        public Gender Gender { get; set; }
        //评价 
        public int pric { get; set; }
        public Employee(string id, string name, int age, Gender gender, int price)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        //回家
        public void GoHome(TrafficTool tool)
        {
            tool.Run();
        }
    }
}

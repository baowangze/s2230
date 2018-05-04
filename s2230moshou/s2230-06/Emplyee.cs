using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2230_06
{
    class Emplyee
    {
        //工号
        public string  ID { get; set; }
        //年龄
        public int Age { get; set; }
        //姓名
        public string Name { get; set; }
        //性别
        public Gender Gender { get; set; }
      
    }
    public class PM:Emplyee
    {
        //带参构造函数，仍然可以调用抽取到Emplyee类中的属性
        public PM(string id,string name,int age , Gender gender ,int yearOfeExperience)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.YearOfExperience = yearOfeExperience;
        }
        //在子类中创建 一个新的。。。。
        private int YearOfExperience;

        public int YearOfExperience1
        {
            get { return YearOfExperience; }
            set { YearOfExperience = value; }
        }
            //问好，返回值：问好的内容
        public string SayHIi()
        {
            string message;
            message = string.Format("大家好，我是{0},今年{1}，项目管理经验{2}年。",this.Name,this.Age,this.YearOfExperience);
            return message;
        }
        public class SE : Emplyee {
            public SE(string id,string name,int age , Gender gender ,int popularity)
            {
                this.ID = id;
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
                this.Popularity = popularity;
            }
            private int Popularity;

            public int Popularity1
            {
                get { return Popularity; }
                set { Popularity = value; }
            }
        }
       
    }
}

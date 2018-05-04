
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmProject
{
    public  class Record
    {
        //签到的时间
        public DateTime SignInTime { get; set; }
        //签退的时间
        public DateTime SignOutTime { get; set; }
        //工号
        public string ID { get; set; }
        //员工姓名
        public string Name { get; set; }
        //员工性别
        public string  Gender { get; set; }
        //员工年龄
        public int Age { get; set; }
    }
}

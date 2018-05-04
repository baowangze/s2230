using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2230_06
{
    class Gender1
    {
        public List<Student> list = new List<Student>();
        public void AddStudent(Student stu)
        {
            list.Add(stu);
        }
        List<string> tuolist = new List<string>();

    }
}

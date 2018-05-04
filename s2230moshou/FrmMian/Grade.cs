using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMian
{
    class Grade
    {
        List<Student> list = new List<Student>();
        public List<string> DisplayStudent(Point point)
        {
            int count = 0;
            List<string> newList = new List<string>();
            foreach (Student item in list)
            {
                count++;
                newList.Add(item.StuName+":"+(point.X + 100*count)+":"+(point.Y+80));
                
            }
            return newList;
        }
        //添加学生
        public void AddStudent(Student stu)
        {
            list.Add(stu);
        }
    }
}

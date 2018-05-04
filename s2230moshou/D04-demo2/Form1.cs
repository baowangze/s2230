using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D04_demo2
{
    public partial class Form1 : Form
    {
        List<Employee> enpls = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Init()
        { 
        //实例化对象
            List<Job> list1 = new List<Job>();
            list1.Add(new Job("编码","购物车模块"));
            list1.Add(new Job ("测试","给购物车模块做单元测试"));
            SE ai = new SE("112", "爱变成", 25, Gender.男, 100, list1);
            List<Job> list2 = new List<Job>();
            list1.Add(new Job("编码", "购物车模块"));
            list1.Add(new Job("测试", "给购物车模块做单元测试"));
            SE joe = new SE("113", "jop", 23, Gender.男, 1033, list2);
            //实例话PM
            PM pm = new PM("113", "ooo", 23, Gender.男, 1033,null);
            enpls.Add(ai);
            enpls.Add(joe);
            enpls.Add(pm);
        }

        private void Report_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in enpls)
            {
                if (emp is  PM)
                {
                    MessageBox.Show(((PM)emp).Dowork(),"汇报");
                }
                if (emp is SE)
                {
                    MessageBox.Show(((SE)emp).DoWork(), "汇报");
                }
            }
        }
    }
}

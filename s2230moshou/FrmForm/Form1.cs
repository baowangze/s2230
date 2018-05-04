using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double numleft = double.Parse(textBox1.Text);//把左边的值拿到
            double numright = double.Parse(textBox2.Text);//把右边的值拿到
            string oper = comboBox1.Text;//运算符
            clackiet cal = CalculatorFoctory.getInstance(oper);//简单化工程
            cal.NumLeft = numleft;//直接给左边的赋值
            cal.NumRight = numright;//直接给右边的赋值
            try
            {
                int resul = Convert.ToInt32(cal.GetType());//子类重新 写挥
                textBox3.Text = resul.ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

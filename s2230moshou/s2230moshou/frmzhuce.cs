using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s2230moshou
{
    public partial class frmzhuce : Form
    {
        public frmzhuce()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmzhuce_Load(object sender, EventArgs e)
        {
              
         }

       

        public string name;
        public string emil;
        public string id;
        public string pwd;
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" )
            {
                MessageBox.Show("请填写信息！！！");
            }
            else
            {
                for (int i = 0; i < frmyong.Iing.Length; i++)
                {
                    if (frmyong.Iing[i]==null)
                    {
                        shuzu shu = new shuzu();
                        shu.UserName1 = textBox1.Text;
                        shu.Id = textBox2.Text;
                        shu.Email = textBox3.Text;
                        shu.Pwd = textBox5.Text;
                        frmyong.Iing[i] = shu;
                    }
                }
                this.Close();
            }
            

        }

       }    
   }

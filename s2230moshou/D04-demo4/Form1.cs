using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D04_demo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.cmdoper.TabIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Boolean s = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == ""||cmdoper.Text.Trim()=="")
            {
                MessageBox.Show("操作不能为空");
                return;
            }
            try
            {
                 Operation opr = new Operation();
                switch (this.cmdoper.SelectedItem.ToString().Trim())
                {
                    case "+":
                        {
                            opr = new OperationAdd();
                            break;
                        }
                    case "-":
                        {
                            opr = new Operjian();
                            break;
                        }
                    case "*":
                        {
                            opr = new Opercheng();
                            break;
                        }
                    case "/":
                        {
                            opr = new OperationDiv();
                            break;
                        }
                }
                opr.NumberA1 = double.Parse(textBox1.Text.Trim());
                opr.NumberB1 = double.Parse(textBox2.Text.Trim());
                //计算
                this.label1.Text = opr.GetResult().ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("发生错误！！！！！！！！！！！");
            }
               
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmProject
{
    public partial class FrmMaintance : Form
    {
        public FrmMain FrmParent { get;set; }
        public FrmMaintance()
        {
            InitializeComponent();
            this.cmbSex.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void tianjia()
        {
            try
            {
                Record or = new Record();
                or.ID = this.txtID.Text.Trim();    //工号
                or.Age = Convert.ToInt32(this.txtAge.Text.Trim()); //年龄
                or.Name = this.txtName.Text.Trim(); //姓名
                if (this.cmbSex.SelectedItem.ToString() == "男")
                {
                    or.Gender = "男";
                }
                else
                {
                    or.Gender = "女";
                }
                foreach (Record item in FrmParent.programmerList)
                {
                    if (item.ID == or.ID)
                    {
                        MessageBox.Show("次工号存在！！");
                        return;
                    }
                }
                FrmParent.programmerList.Add(or);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("出错");
            }
            finally 
            {
                this.FrmParent.BindGrid(FrmParent.programmerList);
                this.Close();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tianjia();
        }

        private void FrmMaintance_Load(object sender, EventArgs e)
        {

        }
    }
}

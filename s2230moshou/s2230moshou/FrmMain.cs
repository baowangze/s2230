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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmzhuce f = new frmzhuce();
            f.Show();
        }

        shuzu shu = new shuzu();
        frmhuanying fm = new frmhuanying();
        public string na;
        public string mo;
        public string ss;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < frmyong.Iing.Length; i++)
            {
                na = frmyong.Iing[i].Email;
                 mo = frmyong.Iing[i].Pwd;
                 ss = frmyong.Iing[i].UserName1;
            }
            
            if (txtEmmail.Text ==na && txtpwd.Text == mo)
            {
                string nname = "欢迎你，" + ss;
                fm.textBox1.Text  = nname;
              
                fm.Show();
            }
            else
            {
                MessageBox.Show("无效！！！");
            }
            
        }
    }
}

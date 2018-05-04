using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMyOffice
{
    public partial class Frmgai : Form
    {
        public Frmgai()
        {
            InitializeComponent();
        }
        
        public ListViewItem select = null;
        private void Frmgai_Load(object sender, EventArgs e)
        {
             
            textBox1.Text = select.SubItems[1].Text;
            textBox2.Text = select.SubItems[3].Text;
            textBox3.Text = select.SubItems[4].Text;
        }
        Form1 f = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            select.SubItems[3].Text = textBox2.Text;
            select.SubItems[4].Text = textBox3.Text;
            this.Close();


        }

    }
}

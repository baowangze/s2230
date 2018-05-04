using System;
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
    public partial class Frmjilu : Form
    {
        public Frmjilu()
        {
            InitializeComponent();
        }
        FrmMain fm = new FrmMain();
       // public Dictionary<string, Record> recordList { get; set; }
        private void Frmjilu_Load(object sender, EventArgs e)
        {  
            dataGridView1.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = fm.recordList.Values;
            this.dataGridView1.DataSource = bs;            
        }
    }
}

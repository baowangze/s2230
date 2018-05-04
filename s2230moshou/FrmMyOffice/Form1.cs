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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public  SE[] se = new SE[3];
        private void Form1_Load(object sender, EventArgs e)
        {

            se[0] = new SE();
            se[0].id = 111;
            se[0].age = 26;
            se[0].name = "王小毛";
            se[0].pingfen = 10;
            se[0].pingjia = "未评价";


            se[1] = new SE();
            se[1].id = 112;
            se[1].age = 26;
            se[1].name = "王中毛";
            se[1].pingfen = 10;
            se[1].pingjia = "未评价";


            se[2] = new SE();
            se[2].id = 113;
            se[2].age = 26;
            se[2].name = "王大毛";
            se[2].pingfen = 10;
            se[2].pingjia = "未评价";
            UpdataaView();
        
        }         
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }
        public void UpdataaView()
        {
            listView1.Items.Clear();
            for (int i = 0; i < se.Length; i++)
            {

                ListViewItem item = new ListViewItem(se[i].id.ToString());
                item.SubItems.Add(se[i].name);
                item.SubItems.Add(se[i].age.ToString());
                item.SubItems.Add(se[i].pingjia);
                item.SubItems.Add(se[i].pingfen.ToString());
                listView1.Items.Add(item);
            }
        }
        #region 打印
        public void add()
        {
            ListViewItem asd = listView1.SelectedItems[0];
            Frmgai f = new Frmgai();
            foreach (var item in se)
            {
                f.select = asd;              
            }
            f.Show();
        }
        #endregion
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            add();
        }

    }
}

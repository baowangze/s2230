using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttjia_Click(object sender, EventArgs e)
        {
            //接受传值
            string textbox = txtbox.Text;
            //将字符串包装成treenode
            TreeNode tn = new TreeNode();
            tn.Text = textbox;

            //3将treenode作为treeview的一个项目
            tvw.Nodes.Add(tn);
        }

        private void bttjiazi_Click(object sender, EventArgs e)
        {
            //接受传值
            string textbox = txtbox.Text;
            //将字符串包装成treenode
            TreeNode tn = new TreeNode();
            tn.Text = textbox;
            TreeNode selectedNode = tvw.SelectedNode;
            foreach (TreeNode item in selectedNode.Nodes)
            {
                if (item.Text == textbox)
                {
                    MessageBox.Show("换");
                }
            }
            selectedNode.Nodes.Add(tn);
        }
    }
}

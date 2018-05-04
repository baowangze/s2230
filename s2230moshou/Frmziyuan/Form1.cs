using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Frmziyuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //添加根节点
            TreeNode nodeRoot = new TreeNode("D:\\");
            nodeRoot.Text = "D:\\";
            nodeRoot.Tag = "D:\\"; //完整的路径
            treeView1.Nodes.Add(nodeRoot);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            //得到当前选项的  
            DirectoryInfo di = new DirectoryInfo(treeView1.SelectedNode.Tag.ToString());//创建目录对象 
            DirectoryInfo[] dirs = di.GetDirectories();//得到子节点
            node.Nodes.Clear();
            //循环 绑定数据
            foreach (DirectoryInfo d in dirs)
            {
                TreeNode node2 = new TreeNode();
                node2.Text = d.Name;
                node2.Tag = d.FullName;
                node.Nodes.Add(node2);
            }
            //得到当前目录下的子文件
            FileInfo[] files = di.GetFiles();
            listView1.Items.Clear();
            foreach (FileInfo fi in files)
            {
                //
                ListViewItem lvi = new ListViewItem();
                lvi.Text = fi.Name;
                lvi.SubItems.Add(fi.Extension.Substring(1));
                lvi.SubItems.Add((fi.Length/1024.0).ToString());
                lvi.SubItems.Add(fi.FullName);
                listView1.Items.Add(lvi);
            }
        }
    }
}

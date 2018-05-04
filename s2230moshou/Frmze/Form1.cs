using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Frmze
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
            TreeNode no = new TreeNode("C:\\");
            no.Tag = "C:\\";
            TreeNode nodeRoot = new TreeNode("E:\\");
            //nodeRoot.Text = "D:\\";
            nodeRoot.Tag = "E:\\"; //完整的路径
            treeView1.Nodes.Add(nodeRoot);
            treeView1.Nodes.Add(no);
            
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            //MessageBox.Show(node.ToString());
            //得到当前选项的    
            DirectoryInfo di = new DirectoryInfo(treeView1.SelectedNode.Tag.ToString());//创建目录对象 
            //MessageBox.Show(di.ToString());
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
            listView1.Items.Clear();//清空
            foreach (FileInfo fi in files)
            {
                //
                ListViewItem lvi = new ListViewItem();
                lvi.Text = fi.Name;//根节点
                lvi.SubItems.Add(fi.Extension);//添加子节点 
                lvi.SubItems.Add((fi.Length / 1024.0).ToString());
                lvi.SubItems.Add(fi.FullName);
                listView1.Items.Add(lvi);
            }
        }
        //复制文件
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //浏览文件的对话廓
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            DialogResult resulet =  fdb.ShowDialog();
            //判断用户是否确定
            if (resulet == DialogResult.OK)
            {
                string path = listView1.SelectedItems[0].SubItems[3].Text;
                string pas = fdb.SelectedPath + "\\" + listView1.SelectedItems[0].Text;
                File.Copy(path,pas,true);
                MessageBox.Show("文件复制成功");
            }
            else
            {
                MessageBox.Show("请选择复制文件");
            }
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==0)
            {
                return;
            }
            //提示用户选择目标文件
            else
            {
                DialogResult result = MessageBox.Show("确定删除吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string patth = listView1.SelectedItems[0].SubItems[3].Text;
                    File.Delete(patth);//删除文件
                    listView1.SelectedItems[0].Remove();//删除lv的数据
                    MessageBox.Show("删除成功！！");
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string path = listView1.SelectedItems[0].SubItems[3].Text;
            Process.Start(path);
        }
    }
}

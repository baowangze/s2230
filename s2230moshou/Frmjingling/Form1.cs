using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frmjingling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        TreeNode allNode  = new TreeNode();
        private void Form1_Load(object sender, EventArgs e)
        {
            //tv上建立的两个节点
            TreeNode myode = new TreeNode();
            myode.Text = "我的电视台";
            //将myNode绑定到tvChannel
            tvChannel.Nodes.Add(myode);
            allNode.Text = "所有电视台";
            tvChannel.Nodes.Add(allNode);
            LoadDataFromXml();
        }
        private void UpdateTreeView()
        { 
        //清空所有子节点
            this.tvChannel.Nodes.Clear();//Nodes是树节点的集合
            //初始话根节点
            TreeNode  nodeFirstLeve = new TreeNode("我的电视台！！");
            nodeFirstLeve.ImageIndex = 0;
        }
        private void LoadDataFromXml()
        {

            //ChannelManager 有一个集合  调度ResolveAllChannels方法集合就有值了
            ChannelManager manager = new ChannelManager();
            manager.ResolveAllChannels();//相当于给集合赋值
            foreach (ChannelBase channel in manager.AllChannels.Values)
            {
                //一个channel在tv上就是一个节点
                TreeNode tn = new TreeNode();
                tn.Tag = channel;
                tn.Text = channel.channelName;
           
                this.tvChannel.Nodes[1].Nodes.Add(tn);

            }
        }
        //选择一项的时候发生的事件
        private void tvChannel_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = tvChannel.SelectedNode;
            //获取选中的节点的level值
            int level = selectedNode.Level;
            if (level==1)
            {
                ChannelBase channel =(ChannelBase)selectedNode.Tag;
                channel.programList.Clear();
                channel.Fetch();//将解析到的内容 加入集合
                
                dgvProgList.DataSource = channel.programList;
            }
            TreeNode node = this.tvChannel.SelectedNode;
           
        }

        private void tvChannel_MouseClick(object sender, MouseEventArgs e)
        {
            //if (node != null && node.Level != 0)
            //{
            //    if (node.Parent.Text == "所有电视台")
            //    {
            //        cmenuRight.Items[0].Visible = false;
            //        cmenuRight.Items[1].Visible = true;
            //    }
            //     else  
            //    {  
            //        //使“删除”菜单项可见  
            //        cmenuRight.Items[0].Visible = false;  
            //        cmenuRight.Items[1].Visible = true;  
            //    }  
            //}  
            //else  
            //{  
            //    cmenuRight.Items[1].Visible = false;  
            //    cmenuRight.Items[0].Visible = false;  
            
            //}
        }

        private void 添加到我的电视ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (TreeNode item in tvChannel.Nodes[0].Nodes )
            {
                if (tvChannel.SelectedNode.Text.Equals(item.Text))
                {
                    MessageBox.Show("该频道已经被添加");

                }

            }
            tvChannel.Nodes[0].Nodes.Add(tvChannel.SelectedNode.Text);
        }

        private void menuTree_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

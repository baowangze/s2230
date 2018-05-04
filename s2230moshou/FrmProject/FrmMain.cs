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
    public partial class FrmMain : Form
    {
        public List<Record> programmerList = new List<Record>();
        public Dictionary<string, Record> recordList = new Dictionary<string, Record>();
        public FrmMain()
        {
            InitializeComponent();
        }
       
        public void BindGrid(List<Record> list)
        {
            
            this.dtvzhu.DataSource = new BindingList<Record>(list);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.dtvzhu.AutoGenerateColumns = false;
        }

       
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaintance f = new FrmMaintance();
            f.FrmParent = this;            
            f.Show();
           
        }

        private void dtvzhu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Record> templist = new List<Record>();
            foreach (Record item in this.programmerList)
            {
                if (item.ID.IndexOf(this.textBox1.Text.Trim())!=-1)
                {
                    templist.Add(item);
                }
            }
            this.dtvzhu.AutoGenerateColumns = false;
            this.dtvzhu.DataSource = new BindingList<Record>(templist);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                string num = dtvzhu.SelectedRows[0].Cells[0].Value.ToString();

                for (int i = 0; i < programmerList.Count; i++)
                {
                    if (programmerList[i].ID == num)
                    {
                        programmerList.Remove(programmerList[i]);
                        BindGrid(programmerList);
                        MessageBox.Show("删除成功！", "提示");
                    }
                }

            }
        }

        #region 签到
        public void qiandao()
        {
            //验证
            //确保有选中的一行
            if (this.dtvzhu.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选中一行！！！！");
                return;
            }
            //确保没有签到
            //CurrentRow         摘要:
            //     获取包含当前单元格的行。
            //
            // 返回结果:
            //     表示当前单元格所在的行的 System.Windows.Forms.DataGridViewRow，如果没有当前单元格，则为 null。
            //       Cells摘要:
            //     获取用于填充行的单元格集合。
            //
            // 返回结果:
            //     一个包含行中的所有单元格的
            string workNo = dtvzhu.CurrentRow.Cells[0].Value.ToString();
            foreach (string id in recordList.Keys)
            {
                if (workNo == id)
                {
                    MessageBox.Show("你已签到过！！");
                    return;
                }
            }
            //执行签到
            Record record = new Record();
            record.ID = workNo;
            record.Name = dtvzhu.CurrentRow.Cells[0].Value.ToString();
            record.SignInTime = DateTime.Now;    //获取系统当前时间
            this.recordList.Add(record.ID, record);//添加到签到记录中
            MessageBox.Show("签到成功！！！！");
        }
        #endregion
        #region 签退
        //确保选中一行
        public void qiantui()
        {
            if (this.dtvzhu.SelectedRows.Count!=1)
            {
                MessageBox.Show("请选中一行！！");
                return;
            }
            string ID = dtvzhu.CurrentRow.Cells[0].Value.ToString();
            bool isOyt = false;//标识是否已经签到过
            foreach (string  key in recordList.Keys)
            {
                if (key ==  ID)
                {
                    //执行签到设置签退时间
                    this.recordList[key].SignInTime = DateTime.Now;
                    MessageBox.Show("签退成功");
                    isOyt = true;
                    break;
                }
            }
            if (!isOyt)
            {
                MessageBox.Show("很抱歉，尚未签到！！");
            }
        }
        #endregion

        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qiandao();
        }

        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qiantui();
        }

        private void 打卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmjilu fj = new Frmjilu();
            fj.recordList = this.recordList;
            fj.Show();
        }
    }
}

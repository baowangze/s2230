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

namespace Frmtaocan
{
    public partial class Form1 : Form
    {
        //定义多个检查项目，供用户给对应的套餐中装配，使其称为套餐的一个项目
        HealthCheckItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        //定义一个系统默认检查套餐“入学体检”
        List<HealthCheckItem> items = new List<HealthCheckItem>();
        public HealthChectSet setA;
        
        //检查所有体检项
        List<HealthCheckItem> AllItems = new List<HealthCheckItem>();
        //使用字典保存套餐集合
        public Dictionary<string, HealthChectSet> healthSet = new Dictionary<string, HealthChectSet>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }     
        #region 初始话体检套餐项目
        public void InitItems()
        {
            height = new HealthCheckItem("身高",5 ,"用于检查身高");
            weight = new HealthCheckItem("体重", 5, "用于检查体重");
            sight = new HealthCheckItem("视力", 10, "用于检查视力");
            hearing = new HealthCheckItem("听力", 10, "用于检查听力");
            liverFun = new HealthCheckItem("肝功能", 5, "用于检查肝功能");
            ekg = new HealthCheckItem("B超", 5, "用于检查B超");
            bWaves = new HealthCheckItem("心电图", 5, "用于检心电图");
            bloodPressure = new HealthCheckItem("血压", 5, "用于检查血压");
            bloodTest = new HealthCheckItem("血常规", 5, "用于检查血常规");
            AllItems.Add(height);
            AllItems.Add(weight);
            AllItems.Add(sight);
            AllItems.Add(hearing);
            AllItems.Add(liverFun);
            AllItems.Add(ekg);
            AllItems.Add(bWaves);
            AllItems.Add(bloodPressure);
            AllItems.Add(bloodTest);
            comItems.DataSource = AllItems;
            comItems.DisplayMember = "name";
            comItems.ValueMember = "money";
        } 
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            show();
            InitSets();
            this.inithealthset();   
            foreach (var item in AllItems)
            {
                comItems.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtming.Text ==" ")
            {
                MessageBox.Show("请输入套餐名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            //HealthChectSet hch = new HealthChectSet();
                this.inithealthset();  
                              
            }
            
        }

        private void cmbming_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string strName = this.cbSets.Text;

            if (strName == "请选择")
            {
                this.dgvHealthList.DataSource = new BindingList<HealthCheckItem>();
                lblSetName.Text = "";
                lblSetPrice.Text = "";
                return;
            }

            //设置套餐名称
            lblSetName.Text = this.cbSets.Text;
            //刷新套餐总价格
            lblSetPrice.Text = this.healthSet[strName].Calcprice().ToString();
            //更新套餐检查项目
           UpdateSet(healthSet[strName]);
            this.btnDel.Enabled = true;
        }

        private void UpdateSet(HealthChectSet set)
        {
            this.dgvHealthList.DataSource = new BindingList<HealthCheckItem>(set.items);
        }
        private void show() {
            height = new HealthCheckItem("身高", 5, "用于检查身高");
            weight = new HealthCheckItem("体重", 5, "用于检查体重");
            sight = new HealthCheckItem("视力", 10, "用于检查视力");
            hearing = new HealthCheckItem("听力", 10, "用于检查听力");
            liverFun = new HealthCheckItem("肝功能", 5, "用于检查肝功能");
            ekg = new HealthCheckItem("B超", 5, "用于检查B超");
            bWaves = new HealthCheckItem("心电图", 5, "用于检心电图");
            bloodPressure = new HealthCheckItem("血压", 5, "用于检查血压");
            bloodTest = new HealthCheckItem("血常规", 5, "用于检查血常规");
            AllItems.Add(height);
            AllItems.Add(weight);
            AllItems.Add(sight);
            AllItems.Add(hearing);
            AllItems.Add(liverFun);
            AllItems.Add(ekg);
            AllItems.Add(bWaves);
            AllItems.Add(bloodPressure);
            AllItems.Add(bloodTest);
            
        }
      
        #region 生成默认套餐数据
        public void InitSets()
        {
            items = new List<HealthCheckItem>();
            items.Add(height);
            items.Add(weight);
            items.Add(liverFun);
            setA = new HealthChectSet("入学体检",items);            
            this.healthSet.Add("入学体检",setA);
        }

        public void inithealthset()
        {
            this.cbSets.Items.Clear();
            this.cbSets.Items.Add("请选择");
            healthSet.Add(this.txtming.Text, null);
            foreach (var item in healthSet.Keys)
            {
                if (item != "")
                {
                    //cbSets.Text =txtming.Text ;
                    //lblSetName.Text = cbSets.Text;
                    this.cbSets.Items.Add(item);
                }
            }
            
            this.cbSets.SelectedIndex = 0;
        }
        #endregion
        #region 加载体检套餐下拉列表
        public void InitHealthSetList()
        { 
        //首先清空套餐下拉列表
            cbSets.Items.Clear();
            //添加请选择 
            cbSets.Items.Add("请选择");
            //将Dictiionary 的key 值绑定到combobox上 ，作为combobox的显示值
            foreach (string  key in healthSet.Keys)
            {
                this.cbSets.Items.Add(key);
            }
            //默认的第一项被选中
            this.cbSets.SelectedIndex = 0;
        }
        #endregion


        #region 添加
        public void tianjia()
        {
            if (this.comItems.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string newname = this.cbSets.Text;
            if (newname == "请选择")
            {
                MessageBox.Show("请选择一个套餐","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            int index = this.comItems.SelectedIndex;
                 healthSet[newname].items.Add(AllItems[index]);
                UpdateSet(this.healthSet[newname]);
               
                this.healthSet[newname].Calcprice();//更新数据
        }
        #endregion
        #region 删除
        public void delete()
        {
            string setName = this.cbSets.Text;
            if (dgvHealthList.SelectedRows.Count == 0)    //首先选中一行
            {
                MessageBox.Show("请选择一项删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int index = dgvHealthList.SelectedRows[0].Index; //获取所删除项的索引  
                this.healthSet[setName].items.RemoveAt(index);
                UpdateSet(healthSet[setName]);                
                //this.healthSet[setName].items.RemoveAt(index);//所删除的项
                this.healthSet[setName].Calcprice();//更新数据
                
            }

        }
        
        #endregion

        private void comItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newname = this.cbSets.Text;
            tianjia();
            this.healthSet[newname].Calcprice();
        }
       
    }
}

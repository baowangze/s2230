using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace FemCar
{
    public partial class Form1 : Form
    {
        Dictionary<string, Abstract> vehices = new Dictionary<string, Abstract>();//实际的
        Dictionary<string, Abstract> rentVehles= new Dictionary<string,Abstract>();//租用的
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chu();
            //MessageBox.Show(vehices);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //初始化
        public void chu()
        {
            //Car c = new Car("白色",20,"京SB250","宾利",3,"张宇",3);
            //Truck b = new Truck("白色", 21, "京SB251", "宾利1", 13, "张宇1", 3,20);
            //vehices.Add(c.LicensoNO,c);
            //vehices.Add(b.LicensoNO, b);
            //
            Car c1 = new Car() 
            {
                LicensoNO = "湘A888888",
                Name = "法拉利A5",
                Color = "白色",
                DailyRent = 5000,
                YearsOfService = 2  
            };
            vehices.Add(c1.LicensoNO, c1);
            

            Car c2 = new Car()
            {
                LicensoNO = "湘A666666",
                Name = "保时捷A5",
                Color = "红色",
                DailyRent = 4000,
                YearsOfService = 2
            };
            vehices.Add(c2.LicensoNO, c2);

            Truck t1 = new Truck
            {
                LicensoNO = "湘B666666",
                Name = "东风A5",
                Color = "蓝色",
                DailyRent = 2000,
                YearsOfService = 2,
                Load = 120
            };
            vehices.Add(t1.LicensoNO, t1);
            new1(vehices, listView1);
        }
        //遍历
        public void bianli()
        { 
        
        }
        //是否租车
        public void zu()
        {

            if (textBox1.Text == "" )
            {
                MessageBox.Show("请填写信息");
                return;
            }
            else
            {
                string key = listView1.SelectedItems[0].Text;
                
                vehices[key].RentUser = this.textBox1.Text;
                rentVehles.Add(vehices[key].LicensoNO, vehices[key]);
                if (vehices.ContainsKey(key))
                {
                    vehices.Remove(key);

                    MessageBox.Show("已出租", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
          
           
        }
        public void new1(Dictionary<string, Abstract> ab, ListView lvlist)
        {

            //ListViewItem list = null;
            lvlist.Items.Clear();

             foreach (Abstract item in ab.Values)  
              {  
              ListViewItem lv = new ListViewItem();  
              lv.Text = item.LicensoNO;  
              lv.SubItems.Add(item.Name);  
              lv.SubItems.Add(item.Color);  
              lv.SubItems.Add(item.YearsOfService.ToString());  
              lv.SubItems.Add(item.DailyRent.ToString());  
              //判断 是 轿车 还是卡车 是卡车 显示载重 ，轿车就显示 无  
              if (item is Truck){
                  lv.SubItems.Add((item as Truck).Load.ToString());  
              }else{
                  lv.SubItems.Add("无");  
              }
              lvlist.Items.Add(lv);
          }  
          
      }  
 
        private void tabPage3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox7.Enabled = false;
            }

            else
            {
                textBox7.Enabled = true;
            }  
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        #region  新车入库
        public void xinxi()
        {
            if (textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" || textBox7.Text.Trim() == "" || comboBox1.Text == "")
            {

                MessageBox.Show("请填写信息！！");
                return;
            }
            Abstract VS = null;
            VS.LicensoNO = textBox3.Text.Trim();
            VS.Name = textBox4.Text.Trim();
            VS.Color = comboBox1.Text.Trim();
            VS.YearsOfService = Convert.ToInt32(textBox5.Text.Trim());
            VS.DailyRent = Convert.ToDouble(textBox6.Text.Trim());

        } 
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            jiesuan();
        }
        #region 结算
        public void jiesuan()
        {
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("请输入租用的天数");
                textBox2.Focus();
                return;
            }
            if (listView2.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择你要结算的车辆");
                return;
            }
            string lin = listView2.SelectedItems[0].Text;
            //MessageBox.Show(lin);
            rentVehles[lin].RentDate = int.Parse(textBox2.Text);
            double tota = rentVehles[lin].CalcPrice();
            string msg = string.Format("您的总价是{0}.",tota.ToString());
            MessageBox.Show(msg, "注意!", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            new1(vehices,listView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            xinxi();
        } 
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new1(rentVehles,listView2);
        }
    }
}

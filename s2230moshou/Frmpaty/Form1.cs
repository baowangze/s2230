using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frmpaty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//获取整行的意思
            //dataGridView1.ContextMenuStrip = ContextMenuStrip;
            List<prect> list = new List<prect>() // 单列集合的样式
            {
            new prect("小贱,杨清柠 - 小太阳","D:\\CloudMusic\\小贱,杨清柠 - 小太阳.mp3"),
            new prect("路默依 - 丁建国写的歌","D:\\CloudMusic\\路默依 - 丁建国写的歌.mp3")//初始化的路径
            };
            //静态数据绑定到dgv上
            dataGridView1.DataSource = new BindingList<prect>(list);
            //DataSource 的意思是数据源 
            //binding list  是直接把只给绑定到list里面

        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmpricSong frm = FrmpricSong.getInstance();
            //选择到选择的歌曲
            string prth = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //赋值给播放窗体的 path变量
            frm.prth = prth;//这个窗体的从listv里面的选择赋给那边的值
            frm.PlaySong();//路径的方法
            frm.Show();
        }

    }
}

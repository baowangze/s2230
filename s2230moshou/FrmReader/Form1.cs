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
namespace FrmReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
             

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            string content = textBox2.Text;
            if (path.Equals(null) || path.Equals(""))
            {
                MessageBox.Show("文件格式不能为空");
                return;
            }
            try
            {
                //创建文件流
                FileStream myfs = new FileStream(path,FileMode.Create);
                //创建写入器
                StreamWriter mysw = new StreamWriter(myfs);
                //将录入的内容写如文件
                mysw.Write(content);
                //关闭写入器
                mysw.Close();
                myfs.Close();
                MessageBox.Show("写入成功！！");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ex.message");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileDi.ShowDialog();

        }

        private void FileDi_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = FileDi.FileName;
        }
        
    }
}

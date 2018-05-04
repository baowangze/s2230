using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qingchu
{
    public partial class Form1 : Gdu.WinFormUI.GMForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control item in  this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox box = item as TextBox;//做转换类型
                    box.Text="";
                }
            }
        }
    }
}

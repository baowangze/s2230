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
    public partial class FrmpricSong : Form
    {
        private FrmpricSong()
        {
            InitializeComponent();
        }
        public string prth;
        public static FrmpricSong onlyOne;
        private void FrmpricSong_Load(object sender, EventArgs e)
        {
            onlyOne = null;
        }
        public void PlaySong()
        {
            Player1.URL = prth;
        }
        public static FrmpricSong getInstance()
        {
            if (onlyOne == null)
            {
                onlyOne = new FrmpricSong();
            }
            return onlyOne;
        }
    }
}

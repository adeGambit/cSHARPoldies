using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void headsButton_Click(object sender, EventArgs e)
        {
            headsPictureBox.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tailsPictureBox.Visible = true;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Political_Joke
{
    public partial class poloticalJoke : Form
    {
        public poloticalJoke()
        {
            InitializeComponent();
        }

        private void leftWingButton_Click(object sender, EventArgs e)
        {
            leftistPunchLineDislpay.Text = "Look Right";
        }

        private void rightWingButton_Click(object sender, EventArgs e)
        {
            rightistSetUpDislpay.Text = "Look Left";
        }

        private void leftPunchLineButton_Click(object sender, EventArgs e)
        {
            leftistPunchLineDislpay.Text = "nothing is left";
        }

        private void rightistPunchLineButton_Click(object sender, EventArgs e)
        {
            rightistSetUpDislpay.Text = "nothing is right";
        }
        private void poloticalJoke_Load(object sender, EventArgs e)
        {

        }
    }
}

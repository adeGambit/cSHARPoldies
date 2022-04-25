using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion_Constellation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showStarNamesButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = true;
            meissaLabel.Visible = true;
            mintakaLabel.Visible = true;
            alnilamButton.Visible = true;
            alnitakLabel.Visible = true;
            saiphLabel.Visible = true;
            rigelLabel.Visible = true;
            //extra credit via representations lack of bare minimum completion
            ic434Label.Visible = true;
            m42Label.Visible = true;
            m43Label.Visible = true;
        }

        private void hideStarNamesButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = false;
            meissaLabel.Visible = false;
            mintakaLabel.Visible = false;
            alnilamButton.Visible = false;
            alnitakLabel.Visible = false;
            saiphLabel.Visible = false;
            rigelLabel.Visible = false;

            ic434Label.Visible = false;
            m42Label.Visible = false;
            m43Label.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //no click required, this was added so the picure would show up at all 
            //shortly later, i fugured out that the picture's visibility property
            //was set to false for some odd reason and i left this section to 
            //remind myself and answer any questions about what mistakes i discovered
            //myself making, in addition to typing this out and LINE commenting in
            //stread of BLOCK commenting. 2 mistakes for the price of one.

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

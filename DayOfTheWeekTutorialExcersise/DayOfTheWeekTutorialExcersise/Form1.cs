using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayOfTheWeekTutorialExcersise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfTheWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfTheMonthTextBox.Text = "";
            yearTextBox.Text = "";

            dateOutputLabel.Text = "";
            //textboxes CLEAR, output label control clear/reset

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();//close/exit the window/application
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            //Declare variable
            string output;
            //concatenate the output and build the output string
            output = dayOfTheWeekTextBox.Text + ", " + monthTextBox.Text + "" 
                + dayOfTheMonthTextBox.Text + "" + yearTextBox.Text;
            dateOutputLabel.Text = output;
        }
    }
}

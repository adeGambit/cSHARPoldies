using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void latinTranslatePromptLabel(object sender, EventArgs e)//promt/label/instructions
        {

        }

        private void sinisterLatinTranlateButton(object sender, EventArgs e)
        {
            translationLabel.Text = "Left";
        }

        private void Sinister(object sender, EventArgs e)
        {
            
        }

        private void dexterTranslateButton(object sender, EventArgs e)
        {
            translationLabel.Text = "Right";
        }

        private void Center(object sender, EventArgs e)
        {
            translationLabel.Text = "Center";
        }

        private void Left(object sender, EventArgs e)
        {

        }
    }
}

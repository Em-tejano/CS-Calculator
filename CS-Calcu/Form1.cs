using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonClick(object sender, EventArgs e)
        {
            /*if (OutputBox.Text == "0")
            {
                OutputBox.Clear();
            }*/

            Button button = (Button)sender;
            OutputBox.Text = OutputBox.Text + button.Text;

        }

        private void dec_Click(object sender, EventArgs e)
        {
            if (OutputBox.Text.Contains("."))
            {

            }
            else
                if(OutputBox.Text=="")
            {
                OutputBox.Text = "0.";
            }
                else
                OutputBox.Text = OutputBox.Text + ".";
        }

        private void clrSecondNumLine_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
        }

        private void clrALL_Click(object sender, EventArgs e)
        {
            OutputBox.ClearUndo();
        }
    }
}

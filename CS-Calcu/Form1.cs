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
        double result = 0;
        string operation = "";
        int ind = 0;
        string d = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //codes for number buttons

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            d = button.Text;

            if(OutputBox.Text == "0" ||OutputBox.Text == "")
            {
                OutputBox.Text = button.Text;
            }

            else
            {
                OutputBox.Text = OutputBox.Text + button.Text;
            }

        }

        //codes for decimal button

        private void dec_Click(object sender, EventArgs e)
        {
            if (OutputBox.Text.Contains("."))
            {

            }

            else
            {
                if (OutputBox.Text == "")
                {
                    OutputBox.Text = "0.";
                }

                else
                {
                    OutputBox.Text = OutputBox.Text + ".";
                }
            }
        }

        //codes for delete last digit encoded

        /*private void back_Click(object sender, EventArgs e)
        {
            ind = OutputBox.Text.LastIndexOf(d);
            OutputBox.Text = OutputBox.Text.Remove(ind);
        }*/

        //codes for sign

        private void sign_Click(object sender, EventArgs e)
        {
            if (OutputBox.Text.Contains("-"))
            {
                OutputBox.Text = OutputBox.Text.Substring(1);
            }

            else
            {
                OutputBox.Text = "-" + OutputBox.Text;
            }
        }

        //codes for reset button

        private void clrALL_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "0";
            result = 0;
        }

        //codes for clear entry button

        private void clrSecondNumLine_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "0";
        }

        //codes for statistical operation buttons

        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(OutputBox.Text);
            OutputBox.Text = "0";
        }

        //codes for equal button

        private void equals_Click(object sender, EventArgs e)
        {
            if (operation == "÷" || operation == "x" )
            {
                if(operation == "÷")
                {
                    OutputBox.Text = (result / Double.Parse(OutputBox.Text)).ToString();
                }

                else
                {
                    OutputBox.Text = (result * Double.Parse(OutputBox.Text)).ToString();
                }
            }

            else
            {
                if(operation=="+")
                {
                    OutputBox.Text = (result + Double.Parse(OutputBox.Text)).ToString();
                }

                else
                {
                    OutputBox.Text = (result - Double.Parse(OutputBox.Text)).ToString();
                }
                OutputBox.Text = "0";
            }
        }


    }
}

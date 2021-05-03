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
        string operation = "";
        int c = 0;
        string a = "";
        string b = "";

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

        //codes for backspace button

        private void back_Click(object sender, EventArgs e)
        {
            if (OutputBox.Text.Length > 0)
            {
                OutputBox.Text = OutputBox.Text.Remove(OutputBox.Text.Length - 1, 1);

                if (OutputBox.Text.Length == 0)
                {
                    OutputBox.Text = "0";
                }
            }
        }

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


        //codes for statistical operation buttons

        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            a = OutputBox.Text;
            c = (a + operation).Length;
            OutputBox.Text = OutputBox.Text + operation;
        }

        //codes for equal button

        private void equals_Click(object sender, EventArgs e)
        {
            b = OutputBox.Text.Substring(c);

            if (operation == "÷" || operation == "x" )
            {
                if(operation == "÷")
                {
                    OutputBox.Text = a + operation + b + "\n" + (Double.Parse(a) / Double.Parse(b)).ToString();
                }

                else
                {
                    OutputBox.Text = a + operation + b + "\n" + (Double.Parse(a) * Double.Parse(b)).ToString();
                }
            }

            else
            {
                if(operation=="+")
                {
                    OutputBox.Text = a + operation + b + "\n" + (Double.Parse(a) + Double.Parse(b)).ToString();
                }

                else
                {
                    OutputBox.Text = a + operation + b + "\n" + (Double.Parse(a) - Double.Parse(b)).ToString();
                }
            }
        }

        //codes for clear entry button

        private void clrSecondNumLine_Click(object sender, EventArgs e)
        {
            OutputBox.Text = a + operation;
        }

        //codes for reset button

        private void clrALL_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "0";
            result = 0;
        }
    }
}

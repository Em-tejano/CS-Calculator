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
    public partial class Calculatr : Form
    {
        string operation = "";
        string PrevOp = "";
        string Num = "";
        string res = "";
        string InByUser = "";
        string PrevNum = "";
        bool opp = true;
        double ress;
        List<double> Memoria = new List<double>();

        public Calculatr()
        {
            InitializeComponent();
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        //for a result of two numbers
        public void Rees()
        {
            if (operation == "÷" || operation == "x")
            {
                DivMul();
            }

            else
            {
                if (operation == "+")
                {
                    res = (Double.Parse(PrevNum) + Double.Parse(Num)).ToString();
                }

                else
                {
                    res = (Double.Parse(PrevNum) - Double.Parse(Num)).ToString();
                }
                OutputBox.Text = InByUser + "\n" + res;
            }
        }

        //division and multiplication as the first buttons to be clicked
        public void DivMul()
        {
            if (operation == "÷")
            {
                res = (Double.Parse(PrevNum) / Double.Parse(Num)).ToString();
            }

            else
            {
                res = (Double.Parse(PrevNum) * Double.Parse(Num)).ToString();
            }
            OutputBox.Text = InByUser + "\n" + res;
        }

        //For continuous input of number

        public void CntnsInput()
        {
            if (operation.Length > 0)
            {
                try
                {
                    if (res.Length > 0)
                    {
                        if (operation == "÷" || operation == "x")
                        {
                            if (operation == "÷")
                            {
                                res = (Double.Parse(res) / Double.Parse(Num)).ToString();
                            }

                            else
                            {
                                res = (Double.Parse(res) * Double.Parse(Num)).ToString();
                            }
                        }

                        else
                        {
                            if (operation == "+")
                            {
                                res = (Double.Parse(res) + Double.Parse(Num)).ToString();
                            }

                            else
                            {
                                res = (Double.Parse(res) - Double.Parse(Num)).ToString();
                            }
                        }
                        OutputBox.Text = InByUser + "\n" + res;
                    }
                    else
                    {
                        Rees();
                    }
                }
                catch (Exception)
                {
                    //if operation is accidentally clicked or intentionally clicked
                    if (operation == "÷" || operation == "x")
                    {
                        PrevNum = "0";
                        InByUser = "0" + InByUser;
                        DivMul();
                    }
                    else
                    {
                        //if add and subtract used as number sign
                        if (operation == "+")
                        {
                            Num = "";
                        }
                        else
                        {
                            Num = operation + Num;
                        }
                    }
                    operation = "";
                }
            }
        }

        //codes for number buttons

        public void NumBtnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Num += button.Text;
            InByUser += button.Text;
            if (opp)
            {
                res = "";
                CntnsInput();
            }
            else
            {
                res = "";
                CntnsInput();
            }
            //res = "";
            //CntnsInput();
            OutputBox.Text = InByUser + "\n" + res;
        }

        //codes for decimal button

        private void dec_Click(object sender, EventArgs e)
        {
            if (Num.Contains("."))
            {

            }

            else
            {
                if (Num == "")
                {
                    Num = "0.";
                    InByUser += "0.";
                }

                else
                {
                    Num += ".";
                    InByUser += ".";
                }
            }
        }

        //after backspace operation
        private void Op()
        {
            if (operation == "÷")
            {
                operation = "x";
            }
            else if (operation == "x")
            {
                operation = "÷";
            }
            else if (operation == "+")
            {
                operation = "-";
            }
            else
            {
                operation = "+";
            }
        }

        //codes for backspace button

        private void back_Click(object sender, EventArgs e)
        {
            if (Num.Length > 0)
            {
                //OutputBox.Text = OutputBox.Text.Remove(InByUser.Length - 1, 1);
                Num = Num.Remove(Num.Length - 1, 1);
                InByUser = InByUser.Remove(InByUser.Length - 1, 1);
                Op();
                CntnsInput();
                Op();
            }
            else
            {
                InByUser = InByUser.Remove(InByUser.Length - 1, 1);

                if (OutputBox.Text.Length == 0)
                {
                    OutputBox.Text = "0";
                }
                else
                {
                    OutputBox.Text = InByUser;
                }
            }
        }

        //codes for sign

        private void sign_Click(object sender, EventArgs e)
        {
            if (Num.Contains("-"))
            {
                OutputBox.Text = OutputBox.Text.Remove(OutputBox.Text.Length - Num.Length, 1);
                InByUser = InByUser.Remove(InByUser.Length - Num.Length, 1);
                Num = Num.Substring(1);
            }

            else
            {
                OutputBox.Text = OutputBox.Text.Insert(OutputBox.Text.Length - Num.Length, "-");
                InByUser = InByUser.Insert(InByUser.Length - Num.Length, "-");
                Num = "-" + Num;
            }
        }


        //codes for statistical operation buttons

        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            if (res.Equals(""))
            {
                opp = false;
                PrevNum = Num;
            }
            else
            {
                opp = true;
                PrevNum = res;
                res = "";
            }

            if (!PrevOp.Equals("") && InByUser.EndsWith(PrevOp))
            {
                InByUser = InByUser.Remove(InByUser.Length - 1, 1);
                InByUser += operation;
            }
            else
            {
                InByUser += operation;
            }
            PrevOp = operation;
            OutputBox.Text = InByUser + "\n" + res;
            Num = "";
        }

        //codes for equal button

        private void equals_Click(object sender, EventArgs e)
        {
            if (res.Length > 0)
            {
                OutputBox.Text = res;
            }
            else
            {
                Rees();
            }
            if (!ress.Equals(0))
            {
                if (operation == "÷")
                {
                    ress /= ((double.Parse(PrevNum) * double.Parse(PrevNum)) / 100);
                }
                else if (operation == "x")
                {
                    ress *= ((double.Parse(PrevNum) * double.Parse(PrevNum)) / 100);
                }
                else if (operation == "+")
                {
                    ress += ((double.Parse(PrevNum) * double.Parse(PrevNum)) / 100);
                }
                else
                {
                    ress -= ((double.Parse(PrevNum) * double.Parse(PrevNum)) / 100);
                }
                ress = Math.Round(ress, 2);
                OutputBox.Text = ress.ToString();
            }
            else
            {
                operation = "";
                Num = "";
                PrevNum = "";
            }
            InByUser = "";
        }

        //codes for clear entry button

        private void clrSecondNumLine_Click(object sender, EventArgs e)
        {
            if (Num.Length > 0)
            {
                OutputBox.Text = InByUser.Remove(InByUser.Length - Num.Length);
                InByUser = InByUser.Remove(InByUser.Length - Num.Length);
                Num = "";
                res = "";
            }
        }

        //codes for reset button

        private void clrALL_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "0";
            res = "";
            Num = "";
            operation = "";
            InByUser = "";
            PrevNum = "";
        }

        private void SqrRt_Click(object sender, EventArgs e)
        {
            double sqrt = Math.Sqrt(double.Parse(Num));
            OutputBox.Text = sqrt.ToString();
        }

        private void Sqr_Click(object sender, EventArgs e)
        {
            double sqr = Math.Pow(double.Parse(Num), 2);
            OutputBox.Text = sqr.ToString();
        }

        private void OneOver_Click(object sender, EventArgs e)
        {
            double frctn = 1 / double.Parse(Num);
            OutputBox.Text = frctn.ToString();
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            if (PrevNum.Equals(""))
            {
                OutputBox.Text = "0";
            }
            else
            {
                if (Num.Equals(""))
                {
                    if (operation == "÷")
                    {
                        ress = double.Parse(PrevNum) / ((double.Parse(PrevNum) * double.Parse(PrevNum)) / 100);
                    }
                    else if (operation == "x")
                    {
                        ress = double.Parse(PrevNum) * ((double.Parse(PrevNum) * double.Parse(PrevNum)) / 100);
                    }
                    else if (operation == "+")
                    {
                        ress = double.Parse(PrevNum) + ((double.Parse(PrevNum) * double.Parse(PrevNum)) / 100);
                    }
                    else
                    {
                        ress = double.Parse(PrevNum) - ((double.Parse(PrevNum) * double.Parse(PrevNum)) / 100);
                    }
                }
                else
                {
                    if (operation == "÷")
                    {
                        ress = double.Parse(PrevNum) / ((double.Parse(PrevNum) * double.Parse(Num)) / 100);
                    }
                    else if (operation == "x")
                    {
                        ress = double.Parse(PrevNum) * ((double.Parse(PrevNum) * double.Parse(Num)) / 100);
                    }
                    else if (operation == "+")
                    {
                        ress = double.Parse(PrevNum) + ((double.Parse(PrevNum) * double.Parse(Num)) / 100);
                    }
                    else
                    {
                        ress = double.Parse(PrevNum) - ((double.Parse(PrevNum) * double.Parse(Num)) / 100);
                    }
                }
                res = ress.ToString();
                OutputBox.Text = res;
            }
        }

        private void MemorySave_Click(object sender, EventArgs e)
        {
            MemoryClear.Enabled = true;
            MemoryRecall.Enabled = true;
            MemoryLister.Enabled = true;
            if (!ress.Equals(0))
            {
                Memoria.Insert(0, ress);
            }
            else if (!res.Equals(""))
            {
                Memoria.Insert(0, double.Parse(res));
            }
            else if (!OutputBox.Text.Equals(""))
            {
                bool isNumber = int.TryParse(OutputBox.Text, out _);
                if (isNumber)
                {
                    Memoria.Insert(0, double.Parse(OutputBox.Text));
                }
                else
                {
                    Memoria.Insert(0, 0);
                }
            }
            else
            {
                Memoria.Insert(0, 0);
            }
        }

        private void MemoryLister_Click(object sender, EventArgs e)
        {
            if (MemoryList.Visible)
            {
                MemoryList.Visible = false;
                MemoryList.Items.Clear();
            }
            else
            {
                MemoryList.Visible = true;
                for (int i = Memoria.Count; i > 0; i--)
                {
                    MemoryList.Items.Add(Memoria[i - 1]);
                }
            }
        }

        private void MemoryList_MouseLeave(object sender, EventArgs e)
        {
            MemoryList.Items.Clear();
            MemoryList.Visible = false;
        }

        private void MemoryAddSub_Click(object sender, EventArgs e)
        {
            MemoryLister.Enabled = true;
            Button button = (Button)sender;
            if (!ress.Equals(0))
            {
                if (button.Text.Equals("M+"))
                {
                    Memoria.Insert(0, Memoria.First() + ress);
                    Memoria.RemoveAt(1);
                }
                else
                {
                    Memoria.Insert(0, Memoria.First() - ress);
                    Memoria.RemoveAt(1);
                }
            }
            else if (!res.Equals(""))
            {
                if (button.Text.Equals("M+"))
                {
                    Memoria.Insert(0, Memoria.First() + double.Parse(res));
                    Memoria.RemoveAt(1);
                }
                else
                {
                    Memoria.Insert(0, Memoria.First() - double.Parse(res));
                    Memoria.RemoveAt(1);
                }
            }
            else if (!OutputBox.Text.Equals(""))
            {
                bool isNumber = int.TryParse(OutputBox.Text, out _);
                if (isNumber)
                {
                    if (Memoria.Count == 0)
                    {
                        if (button.Text.Equals("M+"))
                        {
                            Memoria.Insert(0, double.Parse(OutputBox.Text));
                        }
                        else
                        {
                            Memoria.Insert(0, double.Parse(OutputBox.Text));
                        }
                    }
                    else
                    {
                        if (button.Text.Equals("M+"))
                        {
                            Memoria.Insert(0, Memoria.First() + double.Parse(OutputBox.Text));
                            Memoria.RemoveAt(1);
                        }
                        else
                        {
                            Memoria.Insert(0, Memoria.First() - double.Parse(OutputBox.Text));
                            Memoria.RemoveAt(1);
                        }
                    }
                }
            }
            else
            {
                if (Memoria.Count == 0)
                {
                    Memoria.Insert(0, 0);
                }
                else
                {
                    Memoria.Insert(0, 0);
                    Memoria.RemoveAt(1);
                }
            }
        }
    }
}

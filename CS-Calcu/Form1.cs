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
        double ress;
        List<double> Memoria = new List<double>();
        bool MemSave_Clck = false;
        ArithmeticClass Arith = new ArithmeticClass();
        MemoryClass MemFunc = new MemoryClass();

        public Calculatr()
        {
            InitializeComponent();
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        //codes for number buttons

        public void NumBtnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Num += button.Text;
            InByUser += button.Text;
            Arith.Num = Num;
            Arith.InByUser = InByUser;
            res = "";
            Arith.res = res;
            Arith.CntnsInput();
            res = Arith.res;
            OutputBox.Text = InByUser + "\n" + res;

            if (MemSave_Clck)
            {
                OutputBox.Text = Num;
                MemSave_Clck = false;
            }
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
            Arith.Num = Num;
            Arith.InByUser = InByUser;
        }

        //codes for backspace button

        private void back_Click(object sender, EventArgs e)
        {
            if (Num.Length > 0)
            {
                Num = Num.Remove(Num.Length - 1, 1);
                InByUser = InByUser.Remove(InByUser.Length - 1, 1);
                Arith.Num = Num;
                Arith.InByUser = InByUser;
                Arith.Op();
                Arith.CntnsInput();
                Arith.Op();
            }
            else
            {
                InByUser = InByUser.Remove(InByUser.Length - 1, 1);
                Arith.InByUser = InByUser;

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
                Arith.Num = Num;
                Arith.InByUser = InByUser;
            }

            else
            {
                OutputBox.Text = OutputBox.Text.Insert(OutputBox.Text.Length - Num.Length, "-");
                InByUser = InByUser.Insert(InByUser.Length - Num.Length, "-");
                Num = "-" + Num;
                Arith.Num = Num;
                Arith.InByUser = InByUser;
            }
        }


        //codes for statistical operation buttons

        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            Arith.operation = operation;

            if (!Memoria.Count.Equals(0) && Num.Equals("") && !OutputBox.Text.Equals(""))
            {
                Num = Memoria.First().ToString();
                InByUser += Memoria.First().ToString();
            }

            if (MemSave_Clck)
            {
                MemSave_Clck = false;
            }

            if (res.Equals(""))
            {
                PrevNum = Num;
            }
            else
            {
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
            Arith.PrevNum = PrevNum;
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
                Arith.Rees();
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
            MemFunc.MemorySave();
            MemSave_Clck = true;
            Num = "";
            InByUser = "";
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
                for (int i = 0; i < Memoria.Count; i++)
                {
                    MemoryList.Items.Add(Memoria[i]);
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

        private void MemCall_DoubleClick(object sender, EventArgs e)
        {
            OutputBox.Text = MemoryList.SelectedItem.ToString();
        }

        private void MemoryRecall_Click(object sender, EventArgs e)
        {
            OutputBox.Text = Memoria.First().ToString();
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            Memoria.Clear();
        }
    }
}

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
        string PrevOp = "";
        string res = "";
        string PrevNum = "";
        double ress;
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
            Arith.Num += button.Text;
            Arith.InByUser += button.Text;
            res = "";
            Arith.res = res;
            Arith.CntnsInput();
            res = Arith.res;
            OutputBox.Text = Arith.InByUser + "\n" + res;

            if (MemSave_Clck)
            {
                OutputBox.Text = Arith.Num;
                MemSave_Clck = false;
            }
        }

        //codes for decimal button

        private void dec_Click(object sender, EventArgs e)
        {
            if (Arith.Num.Contains("."))
            {

            }

            else
            {
                if (Arith.Num == "")
                {
                    Arith.Num = "0.";
                    Arith.InByUser += "0.";
                }

                else
                {
                    Arith.Num += ".";
                    Arith.InByUser += ".";
                }
            }
        }

        //codes for backspace button

        private void back_Click(object sender, EventArgs e)
        {
            if (Arith.Num.Length > 0)
            {
                Arith.Num = Arith.Num.Remove(Arith.Num.Length - 1, 1);
                Arith.InByUser = Arith.InByUser.Remove(Arith.InByUser.Length - 1, 1);
                Arith.Op();
                Arith.CntnsInput();
                Arith.Op();
            }
            else
            {
                Arith.InByUser = Arith.InByUser.Remove(Arith.InByUser.Length - 1, 1);

                if (OutputBox.Text.Length == 0)
                {
                    OutputBox.Text = "0";
                }
                else
                {
                    OutputBox.Text = Arith.InByUser;
                }
            }
        }

        //codes for sign

        private void sign_Click(object sender, EventArgs e)
        {
            if (Arith.Num.Contains("-"))
            {
                OutputBox.Text = OutputBox.Text.Remove(OutputBox.Text.Length - Arith.Num.Length, 1);
                Arith.InByUser = Arith.InByUser.Remove(Arith.InByUser.Length - Arith.Num.Length, 1);
                Arith.Num = Arith.Num.Substring(1);
            }

            else
            {
                OutputBox.Text = OutputBox.Text.Insert(OutputBox.Text.Length - Arith.Num.Length, "-");
                Arith.InByUser = Arith.InByUser.Insert(Arith.InByUser.Length - Arith.Num.Length, "-");
                Arith.Num = "-" + Arith.Num;
            }
        }


        //codes for statistical operation buttons

        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Arith.operation = button.Text;

            if (!MemFunc.Memoria.Count.Equals(0) && Arith.Num.Equals("") && !OutputBox.Text.Equals(""))
            {
                Arith.Num = MemFunc.Memoria.First().ToString();
                Arith.InByUser += MemFunc.Memoria.First().ToString();
            }

            if (MemSave_Clck)
            {
                MemSave_Clck = false;
            }

            if (res.Equals(""))
            {
                PrevNum = Arith.Num;
            }
            else
            {
                PrevNum = res;
                res = "";
            }

            if (!PrevOp.Equals("") && Arith.InByUser.EndsWith(PrevOp))
            {
                Arith.InByUser = Arith.InByUser.Remove(Arith.InByUser.Length - 1, 1);
                Arith.InByUser += Arith.operation;
            }
            else
            {
                Arith.InByUser += Arith.operation;
            }
            PrevOp = Arith.operation;
            OutputBox.Text = Arith.InByUser + "\n" + res;
            Arith.Num = "";

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
                Arith.PercentEqual();
                Arith.ress = Math.Round(Arith.ress, 2);
                OutputBox.Text = Arith.ress.ToString();
            }
            else
            {
                Arith.operation = "";
                Arith.Num = "";
                PrevNum = "";
            }
            Arith.InByUser = "";
        }

        //codes for clear entry button

        private void clrSecondNumLine_Click(object sender, EventArgs e)
        {
            if (Arith.Num.Length > 0)
            {
                OutputBox.Text = Arith.InByUser.Remove(Arith.InByUser.Length - Arith.Num.Length);
                Arith.InByUser = Arith.InByUser.Remove(Arith.InByUser.Length - Arith.Num.Length);
                Arith.Num = "";
                res = "";
                Arith.res = "";
            }
        }

        //codes for reset button

        private void clrALL_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "0";
            res = "";
            Arith.InByUser = "";
            PrevNum = "";
            Arith.Awtput = "";
            Arith.Num = "";
            Arith.operation = "";
            Arith.PrevNum = "";
            Arith.res = "";
            Arith.prcnt = 0;
        }

        private void SqrRt_Click(object sender, EventArgs e)
        {
            double sqrt = Math.Sqrt(double.Parse(Arith.Num));
            OutputBox.Text = sqrt.ToString();
        }

        private void Sqr_Click(object sender, EventArgs e)
        {
            double sqr = Math.Pow(double.Parse(Arith.Num), 2);
            OutputBox.Text = sqr.ToString();
        }

        private void OneOver_Click(object sender, EventArgs e)
        {
            double frctn = 1 / double.Parse(Arith.Num);
            OutputBox.Text = frctn.ToString();
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            string prcntVal = "";

            if (PrevNum.Equals(""))
            {
                OutputBox.Text = "0";
                Arith.Num = "";
                Arith.InByUser = "";
            }
            else
            {
                Arith.PercentClick();
                res = Arith.ress.ToString();
                ress = Arith.ress;
                prcntVal = Arith.prcnt.ToString();
                OutputBox.Text = PrevNum + Arith.operation + prcntVal + "\n" + ress;
            }
        }

        private void MemorySave_Click(object sender, EventArgs e)
        {
            MemoryClear.Enabled = true;
            MemoryRecall.Enabled = true;
            MemoryLister.Enabled = true;
            MemFunc.MemorySave();
            MemSave_Clck = true;
            Arith.Num = "";
            Arith.InByUser = "";
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
                for (int i = 0; i < MemFunc.Memoria.Count; i++)
                {
                    MemoryList.Items.Add(MemFunc.Memoria[i]);
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
            MemFunc.BtnTxt = button.Text;
            MemFunc.Awtput = OutputBox.Text;
            MemFunc.AddSub();
        }

        private void MemCall_DoubleClick(object sender, EventArgs e)
        {
            OutputBox.Text = MemoryList.SelectedItem.ToString();
        }

        private void MemoryRecall_Click(object sender, EventArgs e)
        {
            OutputBox.Text = MemFunc.Memoria.First().ToString();
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            MemFunc.Memoria.Clear();
        }
    }
}

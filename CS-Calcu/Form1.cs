﻿using System;
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
        string PrevOp = "";
        string Num = "";
        string res = "";
        string InByUser = "";
        string PrevNum = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

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
                                OutputBox.Text = InByUser + "\n" + res;
                            }

                            else
                            {
                                res = (Double.Parse(res) * Double.Parse(Num)).ToString();
                                OutputBox.Text = InByUser + "\n" + res;
                            }
                        }

                        else
                        {
                            if (operation == "+")
                            {
                                res = (Double.Parse(res) + Double.Parse(Num)).ToString();
                                OutputBox.Text = InByUser + "\n" + res;
                            }

                            else
                            {
                                res = (Double.Parse(res) - Double.Parse(Num)).ToString();
                                OutputBox.Text = InByUser + "\n" + res;
                            }
                        }
                    }
                    else
                    {
                        if (operation == "÷" || operation == "x")
                        {
                            if (operation == "÷")
                            {
                                res = (Double.Parse(PrevNum) / Double.Parse(Num)).ToString();
                                OutputBox.Text = InByUser + "\n" + res;
                            }

                            else
                            {
                                res = (Double.Parse(PrevNum) * Double.Parse(Num)).ToString();
                                OutputBox.Text = InByUser + "\n" + res;
                            }
                        }

                        else
                        {
                            if (operation == "+")
                            {
                                res = (Double.Parse(PrevNum) + Double.Parse(Num)).ToString();
                                OutputBox.Text = InByUser + "\n" + res;
                            }

                            else
                            {
                                res = (Double.Parse(PrevNum) - Double.Parse(Num)).ToString();
                                OutputBox.Text = InByUser + "\n" + res;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    //if operation is accidentally clicked or intentionally clicked
                    if (operation == "÷" || operation == "x")
                    {
                        PrevNum = "0";
                        InByUser = "0" + InByUser;
                        if (operation == "÷")
                        {
                            res = (Double.Parse(PrevNum) / Double.Parse(Num)).ToString();
                            OutputBox.Text = InByUser + "\n" + res;
                        }

                        else
                        {
                            res = (Double.Parse(PrevNum) * Double.Parse(Num)).ToString();
                            OutputBox.Text = InByUser + "\n" + res;
                        }
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
                            Num += operation;
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
            //res = "";
            CntnsInput();
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

        //codes for backspace button

        private void back_Click(object sender, EventArgs e)
        {
            if (Num.Length > 0)
            {
                //OutputBox.Text = OutputBox.Text.Remove(InByUser.Length - 1, 1);
                Num = Num.Remove(Num.Length - 1, 1);
                InByUser = InByUser.Remove(InByUser.Length - 1, 1);
                res = "";
                if (Num.Length > 0)
                {
                    CntnsInput();
                }
                else
                {
                    if (OutputBox.Text.Equals(InByUser))
                    {
                        OutputBox.Text = InByUser;
                    }
                    else
                    {
                        OutputBox.Text = InByUser;
                    }
                }


                if (OutputBox.Text.Length == 0)
                {
                    OutputBox.Text = "0";
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
                if (operation == "÷" || operation == "x")
                {
                    if (operation == "÷")
                    {
                        res = (Double.Parse(PrevNum) / Double.Parse(Num)).ToString();
                        OutputBox.Text = InByUser + "\n" + res;
                    }

                    else
                    {
                        res = (Double.Parse(PrevNum) * Double.Parse(Num)).ToString();
                        OutputBox.Text = InByUser + "\n" + res;
                    }
                }

                else
                {
                    if (operation == "+")
                    {
                        res = (Double.Parse(PrevNum) + Double.Parse(Num)).ToString();
                        OutputBox.Text = InByUser + "\n" + res;
                    }

                    else
                    {
                        res = (Double.Parse(PrevNum) - Double.Parse(Num)).ToString();
                        OutputBox.Text = InByUser + "\n" + res;
                    }
                }
            }
            Num = "";
            operation = "";
            //NumLength = 0;
            InByUser = "";
            PrevNum = "";
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
            //NumLength = 0;
            InByUser = "";
            PrevNum = "";
        }

    }
}

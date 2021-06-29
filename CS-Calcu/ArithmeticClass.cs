using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ArithmeticClass
    {
        public string operation = "";
        public string res = "";
        public string PrevNum = "";
        public string Num = "";
        public string InByUser = "";
        public string Awtput = "";
        public double ress, prcnt = 0;


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
                Awtput = InByUser + "\n" + res;
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
            Awtput = InByUser + "\n" + res;
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
                        Awtput = InByUser + "\n" + res;
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

        //after backspace operation
        public void Op()
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

        //percentage

        public void PercentClick()
        {
            if (Num.Equals(""))
            {
                if (prcnt.Equals(0))
                {
                    prcnt = ((double.Parse(PrevNum) * double.Parse(PrevNum)) / 100);
                    if (operation == "÷")
                    {
                        ress = double.Parse(PrevNum) / prcnt;
                    }
                    else if (operation == "x")
                    {
                        ress = double.Parse(PrevNum) * prcnt;
                    }
                    else if (operation == "+")
                    {
                        ress = double.Parse(PrevNum) + prcnt;
                    }
                    else
                    {
                        ress = double.Parse(PrevNum) - prcnt;
                    }
                }
                else
                {
                    prcnt = ((double.Parse(PrevNum) * prcnt) / 100);
                    if (operation == "÷")
                    {
                        ress = double.Parse(PrevNum) / prcnt;
                    }
                    else if (operation == "x")
                    {
                        ress = double.Parse(PrevNum) * prcnt;
                    }
                    else if (operation == "+")
                    {
                        ress = double.Parse(PrevNum) + prcnt;
                    }
                    else
                    {
                        ress = double.Parse(PrevNum) - prcnt;
                    }
                }
                
            }
            else
            {
                if (prcnt.Equals(0))
                {

                    prcnt = ((double.Parse(PrevNum) * double.Parse(Num)) / 100);
                    if (operation == "÷")
                    {
                        ress = double.Parse(PrevNum) / prcnt;
                    }
                    else if (operation == "x")
                    {
                        ress = double.Parse(PrevNum) * prcnt;
                    }
                    else if (operation == "+")
                    {
                        ress = double.Parse(PrevNum) + prcnt;
                    }
                    else
                    {
                        ress = double.Parse(PrevNum) - prcnt;
                    }
                }
                else
                {
                    prcnt = ((double.Parse(PrevNum) * prcnt) / 100);
                    if (operation == "÷")
                    {
                        ress = double.Parse(PrevNum) / prcnt;
                    }
                    else if (operation == "x")
                    {
                        ress = double.Parse(PrevNum) * prcnt;
                    }
                    else if (operation == "+")
                    {
                        ress = double.Parse(PrevNum) + prcnt;
                    }
                    else
                    {
                        ress = double.Parse(PrevNum) - prcnt;
                    }
                }
            }
        }

        //continuous clicking of equal when perecentage is present

        public void PercentEqual()
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
        }
    }
}

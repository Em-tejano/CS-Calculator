using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MemoryClass
    {
        public double ress;
        public List<double> Memoria = new List<double>();
        string res = "";
        public string Awtput = "", BtnTxt = "";
        public string Num = "";
        public List<string> Hist = new List<string>();

        public void MemorySave()
        {
            if (!ress.Equals(0))
            {
                Memoria.Insert(0, ress);
            }
            else if (!res.Equals(""))
            {
                Memoria.Insert(0, double.Parse(res));
            }
            else if (!Awtput.Equals(""))
            {
                bool isNumber = int.TryParse(Awtput, out _);
                if (isNumber)
                {
                    Memoria.Insert(0, double.Parse(Awtput));
                }
                else
                {
                    Memoria.Insert(0, double.Parse(Num));
                }
            }
            else
            {
                Memoria.Insert(0, 0);
            }
        }

        public void AddSub()
        {
            if (!ress.Equals(0))
            {
                if (BtnTxt.Equals("M+"))
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
                if (BtnTxt.Equals("M+"))
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
            else if (!Awtput.Equals(""))
            {
                bool isNumber = int.TryParse(Awtput, out _);
                if (isNumber)
                {
                    if (Memoria.Count == 0)
                    {
                        if (BtnTxt.Equals("M+"))
                        {
                            Memoria.Insert(0, double.Parse(Awtput));
                        }
                        else
                        {
                            Memoria.Insert(0, double.Parse(Awtput));
                        }
                    }
                    else
                    {
                        if (BtnTxt.Equals("M+"))
                        {
                            Memoria.Insert(0, Memoria.First() + double.Parse(Awtput));
                            Memoria.RemoveAt(1);
                        }
                        else
                        {
                            Memoria.Insert(0, Memoria.First() - double.Parse(Awtput));
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

        public void History()
        {

        }
    }
}

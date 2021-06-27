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
        public string Awtput;
        public string Num;

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
    }
}

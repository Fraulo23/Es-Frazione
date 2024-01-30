using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Frazione
{
    internal class Frazione
    {
        public int Numeratore { get; set; }
        public int Denominatore { get; set; }
        public Frazione(int numeratore, int denominatore)
        {
            Numeratore = numeratore;
            Denominatore = denominatore;
        }
        public int MCD()
        {
            int num = Numeratore;
            int den=Denominatore;
            while (num > 0)
            {
                if (num == den || num == 0 || den == 0)
                {
                    return num;
                }
                if (num > den)
                {
                    num -= den;
                }
                else
                {
                    int tmp = den;
                    den = num;
                    num = tmp;
                }
            }
            return den;
        }
        public void Semplifica()
        {
            int mcd = MCD();
            Numeratore = Numeratore / mcd;
            Denominatore=Denominatore/ mcd;
        }
        public override string ToString()
        {
            Semplifica();
            return Numeratore + "/" + Denominatore;
        }
        public static Frazione Parse(string s)
        {
            string[] frazione=s.Split('/');
            int num = int.Parse(frazione[0]);
            int den = int.Parse(frazione[1]);
            return new Frazione(num, den);
        }

    }
}

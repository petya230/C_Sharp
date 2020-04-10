using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
    public class DHaromszog
    {

        public double a
        {
            get { return aOldal; }
            set
            {
                if (value > 0)
                    aOldal = value;
                else
                    throw new Kivetel("Az 'a' oldal kisebb, mint 0!");
            }
        }
        public double b
        {
            get { return bOldal; }
            set {
                if (value > 0)
                    bOldal = value;
                else
                    throw new Kivetel("A 'b' oldal kisebb, mint 0!");
            }
        }
        public double c
        {
            get { return cOldal; }
            set
            {
                if (value > 0)
                    cOldal = value;
                else
                    throw new Kivetel("A 'c' oldal kisebb, mint 0!");
            }
        }

        private double aOldal, bOldal, cOldal;

        private bool EllDerekszogu
        {
            get { return (c * c == a * a + b * b); }
        }
        private bool EllMegszerkesztheto
        {
            get { return (a + b > c); }
        }
        private bool EllNovekvoSorrend
        {
            get { return (a <= b && b <= c); }
        }
        public double Kerulet
        {
            get { return a + b + c; }
        }
        public double Terulet
        {
            get { return a * b / 2; }
        }
        public int SorSzama
        {
            get;
            set;
        }
        public DHaromszog(string sor, int sorSzama)
        {
            Program p = new Program();

            for (int i = 0; i < sor.Length; i++)
            {
                string[] haromszog = sor.Split(' ');
                a = double.Parse(haromszog[0]);
                b = double.Parse(haromszog[1]);
                c = double.Parse(haromszog[2]);

                if (!EllNovekvoSorrend)
                {
                    throw new Kivetel("Az adatok nincsenek növekvő sorrendben!");
                }
                else if (!EllMegszerkesztheto)
                {
                    throw new Kivetel("A háromszöget nem lehet megszerkeszteni!");
                }
                else if (!EllDerekszogu)
                {
                    throw new Kivetel("A háromszög nem derékszögű!");
                }
            }
        }
    }
}

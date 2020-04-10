using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postfix
{
    class Program
    {
        static void Main(string[] args)
        {
            string bead = "";
            muveletToLengyel(bead);
            lengyelToOsszeg();
            Console.ReadKey();
        }
        static void muveletToLengyel(string _szam)
        {
            string szam = _szam;

        }
        static void lengyelToOsszeg()
        {
            string szam = "52*61/-8+";
            string[] szamok = new string[szam.Length];
            for (int i = 0; i < szam.Length; i++)
            {
                szamok[i] = szam[i].ToString();
            }
            double elso, masodik;
            Stack<double> verem = new Stack<double>();
            for (int i = 0; i < szamok.Length; i++)
            {
                if (!double.TryParse(szamok[i], out double eredmeny))
                {
                    switch (szamok[i])
                    {
                        case "+":
                            masodik = verem.Pop();
                            elso = verem.Pop();
                            verem.Push(elso + masodik);
                            break;
                        case "-":
                            masodik = verem.Pop();
                            elso = verem.Pop();
                            verem.Push(elso - masodik);
                            break;
                        case "/":
                            masodik = verem.Pop();
                            elso = verem.Pop();
                            verem.Push(elso / masodik);
                            break;
                        case "*":
                            masodik = verem.Pop();
                            elso = verem.Pop();
                            verem.Push(elso * masodik);
                            break;
                    }
                }
                else
                {
                    verem.Push(double.Parse(szamok[i]));
                }
            }
            Console.WriteLine(verem.Pop());
        }
    }
}

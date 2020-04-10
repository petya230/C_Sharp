using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            Random r = new Random();
            char meh;
            char[] abc = new char[35] { 'a', 'á', 'b', 'c', 'd', 'e', 'é', 'f', 'g', 'h', 'i', 'í', 'j', 'k', 'l', 'm', 'n', 'o', 'ó', 'ö', 'ő', 'p', 'q', 'r', 's', 't', 'u', 'ú', 'ü', 'ű', 'v', 'w', 'x', 'y', 'z' };
            string szo = "";
            string csakbetuk = "";
            int prim = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(1, 1000);
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                if ((tomb[i] > 9) && (tomb[i] < 100))
                {
                    meh = Convert.ToChar(tomb[i]);
                    szo = szo + meh;
                    Console.WriteLine(meh);
                } 
            }
            Console.WriteLine("összerakott szó: " + szo);
            char[] szetszedve = szo.ToArray();
            for (int i = 0; i < abc.Length; i++)
            {
                for (int j = 0; j < szo.Length; j++)
                {
                    if ((szo[j].ToString() == abc[i].ToString().ToUpper()) || (szo[j] == abc[i])) 
                    {
                        csakbetuk = csakbetuk + szo[j];
                    }
                }
            }
            Console.WriteLine("csak betűk: " + csakbetuk);
            for (int i = 0; i < szo.Length; i++)
            {
                prim = (char)(csakbetuk[i]);
                if (csakbetuk[i] > 1)
                {
                    for (i = 2; i <= Math.Sqrt(csakbetuk[i]); i++)
                    {
                        if (csakbetuk[i] % i == 0)
                        {
                            //Console.WriteLine("Nem prím! ");
                            break;
                        }
                    }
                }
                if (i > Math.Sqrt(csakbetuk[i]))
                {
                    Console.WriteLine(csakbetuk[i]);
                    break;
                }
            }
            Console.WriteLine("A szó kiválogatva: " + csakbetuk);
            Console.ReadKey();
        }
    }
}

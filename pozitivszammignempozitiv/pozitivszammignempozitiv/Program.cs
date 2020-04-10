using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitivszammignempozitiv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            int i = -1;
            int bead;
            int osszeg = 0;
            double atlag = 0;
            Console.WriteLine("Kérem a számokat! Negatív szám a vége");
            do
            {
                bead = int.Parse(Console.ReadLine());
                if (bead > 0)
                {
                    szamok.Add(bead);
                }
                i++;
            } while (bead >= 0);
            foreach (int adatok in szamok)
            {
                Console.WriteLine(adatok);
                osszeg = adatok + osszeg;
            }
            atlag = osszeg / szamok.Count;
            Console.WriteLine("Átlag: " + atlag);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tertomb = new List<string>();
            List<string> tomb = new List<string> { "János", "Eszter", "Endre", "Géza", "Péter", "Norbert", "Mekk mester" };
            //tomb.Remove("Péter");
            Console.WriteLine("Nevek:");
            kiir(tomb);
            foreach (string nev in tomb)
            {
                if (nev.Substring(nev.Length - 3) == "ter")
                {
                    tertomb.Add(nev);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kiválogatva:");
            Console.WriteLine();
            kiir(tertomb);
            Console.ReadKey();
        }
        static void kiir(List<string> tomb)
        {
            foreach (string nev in tomb)
            {
                Console.WriteLine(nev);
            }
        }
    }
}
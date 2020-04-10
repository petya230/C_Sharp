using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Haromszogek
{
    class Program
    {
        static List<string> hibasszogek = new List<string>();
        static List<string> joszogek = new List<string>();
        
        static void Main(string[] args)
        {
            string[] forras = File.ReadAllLines(@"forras.txt");
            
            Console.WriteLine("Rosszak:");
            for (int i = 0; i < forras.Length; i++)
            {
                try {
                    DHaromszog haromszogadatok = new DHaromszog(forras[i], i + 1);
                    joszogek.Add(i + 1 + ".sor: " + forras[i]);
                }
                catch (Kivetel e)
                {
                    Console.WriteLine(i + 1 + ".sor: " + e.uzenet);
                    hibasszogek.Add(i + 1 + ".sor: " + e);
                }
             }

            Console.WriteLine();
            Console.WriteLine("Jók");
            for (int i = 0; i < joszogek.Count; i++)
            {
                Console.WriteLine(joszogek[i]);
            }
            Console.WriteLine();
            int sorszam;
            Console.WriteLine("Kérek egy sorszámot!");
            sorszam = int.Parse(Console.ReadLine());
            for (int i = 0; i < joszogek.Count; i++)
            {
                if(joszogek[i].ToString() == sorszam.ToString())
                {
                    Console.WriteLine(joszogek[i]);
                }
            }

            Console.ReadKey();
        }
    }
}

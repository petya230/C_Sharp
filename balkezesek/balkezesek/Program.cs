using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace balkezesek
{
    class Szemely
    {
        private string nev;
        private DateTime elsopalya;
        private DateTime utolso;
        private int suly;
        private int magassag;

        public Szemely(string _nev, DateTime _elso, DateTime _utolso, int _suly, int _magassag)
        {
            nev = _nev;
            elsopalya = _elso;
            utolso = _utolso;
            suly = _suly;
            magassag = _magassag;
        }
        class Program
        {
            static string[] fajl = File.ReadAllLines("balkezesek.csv");
            static List<Szemely> jatekos = new List<Szemely>();
            static int evszam = 0;
            static void Main(string[] args)
            {
                //2. Feladat
                for (int i = 1; i < fajl.Length; i++)
                {
                    string[] sor = fajl[i].Split(';');
                    Szemely ember = new Szemely(sor[0],DateTime.Parse(sor[1]), DateTime.Parse(sor[2]),int.Parse(sor[3]),int.Parse(sor[4]));
                    jatekos.Add(ember);
                }
                harmadikfeladat();
                negyedikfeladat();
                otodikfeladat();
                hatodikfeladat();
                Console.WriteLine("Feladatok vége...");
                Console.ReadKey();
            }
            static void harmadikfeladat()
            {
                Console.WriteLine("3. Feladat:");
                Console.WriteLine("\tA fájlban " + fajl.Length + " sor található!");
                Console.WriteLine();
            }
            static void negyedikfeladat()
            {
                Console.WriteLine("4. Feladat:");
                for (int i = 0; i < jatekos.Count; i++)
                {
                    if ((jatekos[i].utolso >= new DateTime(1999,10,1)) && (jatekos[i].utolso <= new DateTime(1999, 10, DateTime.DaysInMonth(1999,10))))
                    {
                        Console.WriteLine("\t" + jatekos[i].nev + " : " + Math.Round((jatekos[i].magassag * 2.45), 1) + "cm");
                    }
                }
                Console.WriteLine();
            }
            static void otodikfeladat()
            {
                Console.WriteLine("5. Feladat: ");
                Console.WriteLine("Kérek egy 1990 és 1999 közötti évszámot!");
                evszam = int.Parse(Console.ReadLine());
                do
                {
                    
                    if (!(evszam > 1990 && evszam < 1999))
                    {
                        Console.WriteLine("Hibás adat! Kérek egy 1990 és 1999 közötti évszámot!");
                        evszam = int.Parse(Console.ReadLine());
                    }

                } while (!(evszam > 1990 && evszam < 1999));
                Console.WriteLine();
            }
            static void hatodikfeladat()
            {
                float osszsuly = 0;
                int db = 0;
                DateTime ev = new DateTime(int.Parse(evszam.ToString()),1,1);
                float atlag = 0;

                for (int i = 0; i < jatekos.Count; i++)
                {
                    if (jatekos[i].elsopalya.Year <= ev.Year && ev.Year <= jatekos[i].utolso.Year)
                    {
                        osszsuly += jatekos[i].suly;
                        db++;
                    }
                }
                atlag = osszsuly / db;
                Console.WriteLine(Math.Round(atlag,2) + "font");
            }
        }

    }
}

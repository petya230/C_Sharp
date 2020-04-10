using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cimletezes
{
    class Program
    {
        static int huszas = 0, tizes = 0, otezres = 0, ketezres = 0, ezres = 0, otszaz = 0, ketszaz = 0, szaz = 0, otven = 0, husz = 0, tiz = 0, ot = 0, ketto = 0, egy = 0;
        static int penz = 0;

        static void Main(string[] args)
        {
            string[] szamok = File.ReadAllLines(@"szamok.txt");
            for (int i = 0; i < szamok.Length; i++)
            {
                Szamol(int.Parse(szamok[i]));
            }
            Console.ReadKey();
        }
        static void Szamol(int meh)
        {
            int szamol = meh;
            do
            {
                if (szamol - 20000 >= 0)
                {
                    huszas++;
                    szamol -= 20000;
                }
                else if (szamol - 10000 >= 0)
                {
                    tizes++;
                    szamol -= 10000;
                }
                else if (szamol - 5000 >= 0)
                {
                    otezres++;
                    szamol -= 5000;
                }
                else if (szamol - 2000 >= 0)
                {
                    ketezres++;
                    szamol -= 2000;
                }
                else if (szamol - 1000 >= 0)
                {
                    ezres++;
                    szamol -= 1000;
                }
                else if (szamol - 500 >= 0)
                {
                    otszaz++;
                    szamol -= 500;
                }
                else if (szamol - 200 >= 0)
                {
                    ketszaz++;
                    szamol -= 200;
                }
                else if (szamol - 100 >= 0)
                {
                    szaz++;
                    szamol -= 100;
                }
                else if (szamol - 50 >= 0)
                {
                    otven++;
                    szamol -= 50;
                }
                else if (szamol - 20 >= 0)
                {
                    husz++;
                    szamol -= 20;
                }
                else if (szamol - 10 >= 0)
                {
                    tizes++;
                    szamol -= 10;
                }
                else if (szamol - 5 >= 0)
                {
                    ot++;
                    szamol -= 5;
                }
                else if (szamol - 2 >= 0)
                {
                    ketto++;
                    szamol -= 2;
                }
                else if (szamol - 1 >= 0)
                {
                    egy++;
                    szamol -= 1;
                }
            } while (szamol != 0);
            kiir(meh);
        }
        static void kiir(int meh)
        {
            Console.WriteLine("Összeg: " + meh);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Húszezres: " + huszas);
            Console.WriteLine("Tízezres: " + tiz);
            Console.WriteLine("Ötezres: " + otezres);
            Console.WriteLine("Kétezres: " + ketezres);
            Console.WriteLine("Ezres: " + ezres);
            Console.WriteLine("Ötszázas: " + otszaz);
            Console.WriteLine("Kétszázas: " + ketszaz);
            Console.WriteLine("Százas: " + szaz);
            Console.WriteLine("Ötvenes: " + otven);
            Console.WriteLine("Huszas: " + husz);
            Console.WriteLine("Tizes: " + tizes);
            Console.WriteLine("Ötös: " + ot);
            Console.WriteLine("Kettes: " + ketto);
            Console.WriteLine("Egyes: " + egy);
            Console.WriteLine("----------------------------");
            Nullaz();
        }
        static void Nullaz()
        {
            huszas = 0; tizes = 0; otezres = 0; ketezres = 0; ezres = 0; otszaz = 0; ketszaz = 0; szaz = 0; otven = 0; husz = 0; tiz = 0;  ot = 0; ketto = 0; egy = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Nobel
{
    class Program
    {
        static void Main(string[] args)
        {
            string adat = File.ReadAllText(@"nobel.csv");
            string[] bontottAdat = adat.Split(new Char[] { '\n', ';' });
            Console.Write("3. Feladat: ");
            for (int i = 0; i < bontottAdat.Length; i++)
            {
                if (bontottAdat[i] == "Arthur B.")
                {
                    Console.Write(bontottAdat[i - 1]);
                }
            }
            Console.WriteLine();
            Console.Write("4. Feladat: ");
            for (int i = 0; i < bontottAdat.Length; i++)
            {
                if (bontottAdat[i] == "2017")
                {
                    if (bontottAdat[i + 1] == "irodalmi")
                        Console.WriteLine(bontottAdat[i + 2] + " " + bontottAdat[i + 3]);
                }
            }
            Console.WriteLine("5. Feladat: ");
            for (int i = 0; i < bontottAdat.Length; i++)
            {
                if (bontottAdat[i] == "\r" && int.Parse(bontottAdat[i - 3]) >= 1990)
                {
                    Console.WriteLine("\t" + bontottAdat[i - 3] + " " + bontottAdat[i - 1]);
                }
            }
            Console.WriteLine("6. Feladat: ");
            bontottAdat = adat.Split(new Char[] { '\n', ';', '\r' });
            string sor;
            for (int i = 0; i < bontottAdat.Length; i++)
            {
                if (bontottAdat[i].ToLower().Contains("curie"))
                {
                    sor = "\t" + bontottAdat[i - 3] + " ";
                    sor += bontottAdat[i - 1] + " ";
                    sor += bontottAdat[i] + "(" + bontottAdat[i - 2] + ")";
                    //Console.Write(bontottAdat[i - 3] + " " + bontottAdat[i - 1] + " " + bontottAdat[i] + "(" + bontottAdat[i - 2] + ")");
                    Console.WriteLine(sor);
                }
            }
            Console.WriteLine("7. Feladat: ");
            int[] dijak = new int[6];
            string[] dij = { "fizikai", "kémiai", "orvosi", "irodalmi", "béke", "közgazdaságtani" };
            for (int i = 0; i < dijak.Length; i++)
            {
                dijak[i] = 0;
            }
            for (int i = 0; i < bontottAdat.Length; i++)
            {
                switch(bontottAdat[i])
                {
                    case "fizikai":
                        dijak[0]++;
                        break;
                    case "kémiai":
                        dijak[1]++;
                        break;
                    case "orvosi":
                        dijak[2]++;
                        break;
                    case "irodalmi":
                        dijak[3]++;
                        break;
                    case "béke":
                        dijak[4]++;
                        break;
                    case "közgazdaságtani":
                        dijak[5]++;
                        break;
                }
            }
            for (int i = 0; i < dijak.Length; i++)
            {
                Console.WriteLine("\t" + dij[i] + "\t\t\t" + dijak[i] + " db");
            }
            Console.WriteLine();
                Console.ReadKey();
        }
    }
}
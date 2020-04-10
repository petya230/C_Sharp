using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo_szigetek
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            List<int> szigetek = new List<int>();
            int[] meresek = new int[25];
            Random rnd = new Random();
            for (int i = 0; i < meresek.Length; i++)
            {
                meresek[i] = rnd.Next(0, 100);
                if (meresek[i] > 40)
                {
                    meresek[i] = rnd.Next(1, 11);
                }
                else
                {
                    meresek[i] = 0;
                }
            }
            kiir(meresek);
            Console.WriteLine();
            legmagasabbpont(meresek, max);
            Console.WriteLine();
            sziget(meresek, szigetek, max);
            Console.ReadKey();
        }
        static void kiir(int[] tomb)
        {
            foreach (int item in tomb)
            {
                Console.Write(item + ", ");
            }
        }
        static int legmagasabbpont(int[] tomb, int max)
        {
            int maxindex = 0, maxdb = 1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == max)
                {
                    maxdb++;
                }
                else if (tomb[i] > max)
                {
                    max = tomb[i];
                    maxindex = i;
                }
            }
            Console.WriteLine("Legmagasabb pont: {0} és az indexe: {1}", max, maxindex);
            Console.WriteLine("{0} alkalommal fordult elő a legmagasabb pont!", maxdb);
            return max;
        }
        static void sziget(int[] tomb, List<int> sziget, int max)
        {
            bool van = false, nem = false;
            int maxsz = int.MinValue;
            int szamlalas = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > 0)
                {
                    szamlalas++;
                    if (tomb[i] == max)
                    {
                        van = true;
                    }
                }
                else if (tomb[i] == 0)
                {
                    if (szamlalas > maxsz)
                    {
                        maxsz = szamlalas;
                        if (van)
                        {
                            nem = true;
                        }
                        else
                        {
                            nem = false;
                        }
                    }
                    van = false;
                    szamlalas = 0;
                }
            }
            Console.WriteLine("Leghoszabb sziget: " + maxsz);
            Console.WriteLine();
            if (nem)
            {
                Console.WriteLine("Rajta van");
            }
            else
            {
                Console.WriteLine("Nincs rajta");
            }
        }
    }
}
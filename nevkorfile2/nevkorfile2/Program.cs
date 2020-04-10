using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevkorfile2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] baratok = (File.ReadAllLines(@"baratok.txt"));
            List<string> Abarik = new List<string>();
            List<string> Bbarik = new List<string>();
            for (int i = 0; i < baratok.Length; i++)
            {
                if (baratok[i].Contains('\n'))
                {
                    Abarik.Add(baratok[i].Split('\r')[0]);
                    Bbarik.Add(baratok[i].Split('\r')[1]);
                }
            }
            Console.WriteLine("Abarik:");
            listkiir(Abarik);
            Console.WriteLine("Bbarik:");
            listkiir(Bbarik);
            Console.ReadKey();
        }
        static void kiir(string[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
        static void listkiir(List<string> tomb)
        {
            for (int i = 0; i < tomb.Count; i++)
            {
                Console.Write(tomb[i] + " ");
                Console.WriteLine();
            }
        }
    }
}

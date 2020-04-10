using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevKorFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emberek = (File.ReadAllLines(@"adatok.txt"));
            List<string> felnott = new List<string>();
            kiir(emberek);
            for (int i = 0; i < emberek.Length; i++)
            {
                if (emberek[i].Contains(';'))
                {
                    if (int.Parse(emberek[i].Split(';')[1]) >= 18)
                    {
                        felnott.Add(emberek[i].Split(';')[0] + " " + emberek[i].Split(';')[1]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("18 évesek vagy felettiek: ");
            listkiir(felnott);
            Console.WriteLine();
            File.WriteAllLines(@"adatokszerkesztve.txt", felnott);
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
            for(int i = 0; i < tomb.Count; i++)
            {
                Console.Write(tomb[i] + " ");
                Console.WriteLine();
            }
        }
    }
}

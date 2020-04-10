using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beker2tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            //adat bekérés
            Console.WriteLine("meh");
            string beker = Console.ReadLine();
            int[] tomb = new int[beker.Length];
            Console.WriteLine();
            //kiiratás
            for (int i = 0; i < tomb.Length; i++)
            {
                char c = beker[i];
                tomb[i] = int.Parse(c.ToString());
                Console.Write(tomb[i] + " ");
            }
            //első és utolsó csere
            csere(tomb);
            Console.WriteLine();
            kiir(tomb);
            Console.WriteLine();
            //kiiratás visszafelé
            Array.Reverse(tomb);
            kiir(tomb);
            Console.WriteLine();
            //kiiratás eredeti
            Array.Reverse(tomb);
            csere(tomb);
            kiir(tomb);
            Console.WriteLine();
            //kiiratás rendezve
            Array.Sort(tomb);
            kiir(tomb);
            Console.ReadKey();
        }
        static void kiir(int[] tomb)
        {
            foreach (int szam in tomb)
            {

                Console.Write(szam + " ");
            }
        }
        static void csere(int[] tomb)
        {
            int tmp = tomb[tomb.Length - 1];
            tomb[tomb.Length - 1] = tomb[0];
            tomb[0] = tmp;
        }
    }
}

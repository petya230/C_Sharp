using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombrendezes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Tomb2 = new List<int>();
            ArrayList tomb = new ArrayList() { 1, 4, 6, 8, 9, 3, 6, 2, 5 };
            Console.WriteLine("A tömb:");
            kiir(tomb);
            fordit(tomb);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A fordított tömb:");
            kiir(tomb);
            Console.ReadKey();
        }
        static void kiir(ArrayList tomb)
        {
            foreach (int szamok in tomb)
            {
                Console.Write(szamok + ", ");
            }
        }
        static void fordit(ArrayList tomb)
        {
            int tmp;
            for (int i = 0; i < tomb.Count / 2; i++)
            {
                //Console.WriteLine(j);
                tmp = (int)tomb[i];
                tomb[i] = tomb[tomb.Count - i - 1];
                tomb[tomb.Count - i - 1] = tmp;
            }
        }
    }
}

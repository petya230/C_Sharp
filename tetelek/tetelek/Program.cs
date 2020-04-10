using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int minindex = 0;
            int osszeg = 0;
            int x = 0;
            bool otteloszthato = false;
            int otteloszthatodb = 0;
            int oszt = 0;
            int[] tomb = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1,1000);
                Console.Write(tomb[i] + ", ");
                osszeg = osszeg + tomb[i];
                if (tomb[i] % 5 == 0)
                {
                    otteloszthatodb++;
                    otteloszthato = true;
                }
                if (tomb[i]<min)
                {
                    min = tomb[i];
                    minindex = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(otteloszthato ? "Van benne öttel osztható szám!" : "Nincs benne öttel osztható!");
            do
            {
                if (tomb[x] % 5 == 0)
                {
                    Console.WriteLine("A tomb {0}. tagja osztható 5.-el!", x);
                    oszt++;
                }
                x++;
            } while (oszt < 1);
            Console.WriteLine("Összesen {0} db 5.-el osztható szám van!", otteloszthatodb);
            Console.WriteLine("A legkisebb érték indexe: " + minindex);
            Console.ReadKey();
        }
    }
}

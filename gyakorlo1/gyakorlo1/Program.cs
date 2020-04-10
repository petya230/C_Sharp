using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fak = 0;
            int eredmeny = 1;
            Console.WriteLine("Kérem a faktoriálist!");
            fak = int.Parse(Console.ReadLine());
            for (int i = 1; i <= fak; i++) 
            {
                eredmeny = eredmeny * i;
            }
            Console.WriteLine(eredmeny);
            Console.WriteLine("Nyomj entert a kövi feladathoz!");
            Console.ReadKey();
            int alap = 0, kitevo = 0;
            Console.WriteLine("Kérem az alapot és a kitevőt!");
            Console.WriteLine("alap:");
            alap = int.Parse(Console.ReadLine());
            Console.WriteLine("kitevő:");
            kitevo = int.Parse(Console.ReadLine());
            eredmeny = 1;
            for (int i = 0; i < kitevo; i++)
            {
                eredmeny = eredmeny * alap;
            }
            Console.WriteLine(eredmeny);
            Console.ReadKey();
        }
    }
}

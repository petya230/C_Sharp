using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzokoevVagySem
{
    class Program
    {
        static void Main(string[] args)
        {
            int ev = 0;
            Console.WriteLine("Kérem az évet!");
            ev = int.Parse(Console.ReadLine());
            if ((ev % 4 == 0) || (ev % 100 == 0) && (ev % 400 == 0)) 
            {
                Console.WriteLine("Szököév!");
            }
            else
            {
                Console.WriteLine("Nem szökőév!");
            }
            Console.ReadKey();
        }
    }
}

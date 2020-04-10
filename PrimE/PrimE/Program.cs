using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimE
{
    class Program
    {
        static void Main(string[] args)
        {
            int prim = 0;
            Console.WriteLine("Kérek egy számot!");
            prim = int.Parse(Console.ReadLine());
            int i = 0;
            if (prim > 1)
            {
                for (i = 2; i <= Math.Sqrt(prim); i++)
                {
                    if (prim % i == 0)
                    {
                        Console.WriteLine("Nem prím! ");
                        break;
                    }
                }
            }
            if (i > Math.Sqrt(prim))
            {
                Console.WriteLine("A szám prím!");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace honapneve
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] honapok = { "Január", "Február", "Március" };
            string beker = "";
            Console.WriteLine("!");
            beker = Console.ReadLine();
            for (int i = 0; i < honapok.Length; i++)
            {
                if (beker == honapok[i])
                {
                    Console.WriteLine("A beírt szó, egy hónap neve");
                }
            }
            Console.ReadKey();
        }
    }
}

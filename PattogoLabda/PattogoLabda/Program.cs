using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PattogoLabda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Milyen magasról essen a labda?");
            int magassag = int.Parse(Console.ReadLine());
            Palya p = new Palya(magassag);
            Console.ReadKey();
        }
    }
}

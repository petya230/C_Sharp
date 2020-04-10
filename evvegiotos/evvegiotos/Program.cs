using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evvegiotos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] jegyek = { 5, 5, 5, 5, 5, 5, 5 };
            while (i < jegyek.Length && jegyek[i] == 5)
            {
                i++;
            }
            Console.WriteLine(i<jegyek.Length? "Nem volt kítűnő":"Kítűnő volt");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamokosztoja
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 10007;
            for (int i = 1; i < szam + 1; i++)
            {
                if (szam % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}

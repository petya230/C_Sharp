using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sorozat = new int[] { 1, 2, 3, 3, 4, 6, 5, 4, 3,2 };
            int kivonat = 0;
            for (int i = 1; i < sorozat.Length - 1; i++)
            {
                kivonat = sorozat[i] - sorozat[i - 1];
                if (kivonat == sorozat[i + 1] - sorozat[i])
                {
                    Console.WriteLine("meh: " + sorozat[i - 1] + ", " + sorozat[i] + ", " + sorozat[i + 1]);
                }
            }
            Console.ReadKey();
        }
    }
}

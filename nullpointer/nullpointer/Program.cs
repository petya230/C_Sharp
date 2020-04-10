using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullpointer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nope = new int[10];
            for (int i = 0; i < nope.Length; i++)
            {
                nope[0] = 3;
                Console.WriteLine(nope[i]);
            }
            Console.ReadKey();
        }
    }
}

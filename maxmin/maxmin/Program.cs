using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MinValue;
            int max = int.MinValue;
            int[] tomb = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Kérem a(z) {0}. elemet!", i + 1);
                tomb[i] = int.Parse(Console.ReadLine());
                if (min < tomb[i]) 
                {
                    min = tomb[i];
                }
                if (max > tomb[i])
                {
                    max = tomb[i];
                }
            }
        }
    }
}

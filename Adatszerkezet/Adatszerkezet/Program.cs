using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatszerkezet
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> sor = new Queue<int>();
            Stack<int> verem = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                sor.Enqueue(i);
                verem.Push(i);
            }
            Console.WriteLine("Sor:");
            foreach (var item in sor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Verem");
            foreach (var item in verem)
            {
                Console.WriteLine(item);
            }
                Console.ReadKey();
        }
    }
}

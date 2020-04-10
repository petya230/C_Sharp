using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmusGyak
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;
            Console.WriteLine("Kérem az 'a', a 'b' és a 'c' értékét!");
            Console.WriteLine("'a':");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("'b':");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("'c':");
            c = double.Parse(Console.ReadLine());
            double dis = Math.Pow(b, (double)2) + (-4 * a * c);
            if ( dis < 0)
            {
                Console.WriteLine("Nincs megoldás!");
            }
            else if (dis == 0)
            {
                Console.WriteLine("Csak egy megoldása van!");
                x1 = (-b + (Math.Sqrt(dis) / (2 * a)));
                Console.WriteLine("X1 megoldása: " + x1);
            }
            else if (dis > 0)
            {
                Console.WriteLine("2 megoldása van!");
                x1 = (-b + (Math.Sqrt(dis) / (2 * a)));
                x2 = (-b - (Math.Sqrt(dis) / (2 * a)));
                Console.WriteLine("X1 megoldása: " + x1);
                Console.WriteLine("X2 megoldása: " + x2);
            }
            Console.ReadKey();
        }
    }
}

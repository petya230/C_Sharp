using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autovezeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Vezeto v = new Vezeto("Péter");
            Vezeto v2 = new Vezeto("Pál");
            //Console.WriteLine(v.bemutatkozik());

            Auto a1 = new Auto("rsz-01");
            Console.WriteLine(a1);
            //a1.beszall(new Vezeto("Péter"));
            Console.WriteLine(a1);
            a1.kiszall();
            Console.WriteLine(a1);
            Console.WriteLine();
            Auto a2 = new Auto("rsz-02");
            Console.WriteLine(a2);
            //a2.beszall(new Vezeto("Pál"));
            Console.WriteLine(a2);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Autók:");
            Console.WriteLine(a1);
            Console.WriteLine(a2);

            Console.WriteLine("Vezetők:");
            Console.WriteLine(v);
            Console.WriteLine(v2);
            Console.WriteLine("---------------------------------------");
            a1.beszall(v);
            a2.beszall(v);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(v);
            Console.WriteLine(v2);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBenzin
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            a1.Ment();
            a1.Ment();
            a1.Tankol();
            Console.ReadKey();
        }
    }
}

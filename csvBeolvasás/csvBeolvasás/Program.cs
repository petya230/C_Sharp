using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csvBeolvasás
{
    class Program
    {
        static void Main(string[] args)
        {
            string filenev = "valami.txt";
            Beolvas be = new Beolvas(filenev);
            Console.ReadKey();
        }
    }
}

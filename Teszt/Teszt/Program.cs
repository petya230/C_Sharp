
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("szovegek.csv");
            File.WriteAllLines("szovegek.csv", beolvas);
        }
    }
}

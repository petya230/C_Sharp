using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplaz
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            szam = int.Parse(Console.ReadLine());
            Duplaz(szam);
        }
        static int Duplaz(int szam)
        {
            szam = szam * 2;
            return szam;
        }
        static void Tulterhelt(string nev)
        {
            Console.WriteLine("Név: " + nev);
        }
        static void Tulterhelt(string nev, string nev2)
        {
            Console.WriteLine("Vezetéknév: {0}, keresztnév: {1}", nev, nev2);
        }
        static void Tulterhelt(string nev, double fiz)
        {
            Console.WriteLine("Név: {0} , fizetés: {1}", nev, fiz);
        }
    }
}
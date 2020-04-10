using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vilag v = new Vilag(23);
            //csak akkor fogom elérni, ha publikus Vilag terulet adattagja
            //Console.WriteLine("A jelenlegi világ területe: " + v.terulet);
            Console.WriteLine("A jelenlegi világ területe: " + v.getTerulet());
            int ujTerulet = v.tagul();
            Console.WriteLine("A jelenlegi világ területe: " + ujTerulet);
            Console.WriteLine();

            Sarkany s = new Sarkany();
            s.oregedik();
            Console.WriteLine();
            VorosSarkany vs = new VorosSarkany();
            vs.tuz();
            Console.WriteLine();
            vs.oregedik();
            Console.WriteLine();
            vs.Tapasztalat();
            Console.WriteLine();
            vs.tuz();
            Console.WriteLine();
            vs.tuz();
            Console.WriteLine();
            vs.tuz();
            Console.WriteLine();
            vs.pihen();
            Console.WriteLine();
            vs.tuz();
            Console.WriteLine();
            vs.tuz();
            Console.WriteLine();
            vs.tuz();
            Console.WriteLine();
            vs.pihen();
            Console.WriteLine();
            vs.tuz();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Stat.: ");
            Console.WriteLine(v.ToString());
            Console.WriteLine(v);
            Console.WriteLine(s);
            Console.WriteLine(vs);
            Console.ReadKey();
        }
    }
}

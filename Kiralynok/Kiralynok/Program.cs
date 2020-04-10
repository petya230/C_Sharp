using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kiralynok
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabla tabla = new Tabla('#');
            Console.WriteLine("4. feladat: Az üres tábla:");
            tabla.Megjelenit();
            Console.WriteLine();
            Console.WriteLine("6. feladat: A feltöltött tábla: ");
            tabla.Elhelyez(8);
            tabla.Megjelenit();
            Console.WriteLine();
            Console.WriteLine("9. feladat: Üres oszlopok és sorok száma: ");
            tabla.UresOszlopokSzama();
            tabla.UresSorokSzama();
            for (int i = 0; i < 65; i++)
            {
                tabla = new Tabla('*');
                tabla.Elhelyez(i);
                Console.WriteLine();
                Console.WriteLine(i + ".k példány...");
                tabla.Megjelenit();
                tabla.FajlBaIr();

            }

            Console.ReadKey();
        }
    }
}

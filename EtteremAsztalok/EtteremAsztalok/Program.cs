using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EtteremAsztalok
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ar = new Dictionary<string, int>();

            string etelek = File.ReadAllText("etelek.txt");
            string asztalok = File.ReadAllText("asztalok.txt");
            string[] arlista = etelek.Split(new char[] { '|', '\n'});
            string[] rendelesek = asztalok.Split('\n');
            for (int i = 0; i < arlista.Length; i += 2)
            {
                ar.Add(arlista[i], int.Parse(arlista[i + 1]));
            }
            Console.WriteLine("Árlista: ");
            test(ar);
            Console.WriteLine();
            Console.WriteLine("Rendelések: ");
            test(rendelesek);
            Console.ReadKey();
        }
        static void test(Dictionary<string, int> teszt)
        {
            foreach (var meh in teszt)
                Console.WriteLine(meh);
        }
        static void test(string[] teszt)
        {
            foreach (var meh in teszt)
                Console.WriteLine(meh);
        }
    }
}

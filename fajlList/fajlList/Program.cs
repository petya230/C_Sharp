using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace fajlList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ip = (File.ReadAllLines( @"ip.txt"));
            List<int> host = new List<int>();
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Console.WriteLine();
            kiir(ip);
            Console.WriteLine();
            Console.WriteLine("Rendezett:");
            for (int i = 0; i < ip.Length; i++)
            {
                if (ip[i].Contains('.'))
                {
                    host.Add(int.Parse(ip[i].Split('.')[3]));
                }
            }
            host.Sort();
            listkiir(host);
            Console.WriteLine();
            Console.ReadKey();
        }
        static void kiir(string[] tomb)
        {
            for (int i = 1; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
        static void listkiir(List<int>tomb)
        {
            foreach (int ip in tomb)
            {
                Console.Write(ip + ", ");
            }
        }
    }
}

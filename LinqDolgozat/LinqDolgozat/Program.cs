using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elso = new int[] { 2, 4, 6, 8, 2, 1, 2, 3 };
            int[] masodik = new int[] { 1, 3, 5, 7, 1, 1, 2, 3 };
            string[] strtomb = new string[] { "Béla", "Jolán", "Bill", "Shakespeare", "Verne", "Jókai" };

            List<Diak> diakok = new List<Diak>();
            diakok.Add(new Diak("Első Egon", 52));
            diakok.Add(new Diak("Második Miksa", 97));
            diakok.Add(new Diak("Harmadik Huba", 10));
            diakok.Add(new Diak("Negyedik Néró", 89));
            diakok.Add(new Diak("Ötödik Ödön", 69));
            Console.WriteLine("1. feladat");
            Feladat1(elso);
            Console.WriteLine();
            Console.WriteLine("2. feladat");
            Feladat2(strtomb);
            Console.WriteLine();
            Console.WriteLine("3. feladat");
            Feladat3(elso);
            Console.WriteLine();
            Console.WriteLine("4. feladat");
            Feladat4(strtomb);
            Console.WriteLine();
            Console.WriteLine("5. feladat");
            Feladat5(diakok);
            Console.WriteLine();
            Console.WriteLine("6. feladat");
            Feladat6(diakok);
            Console.WriteLine();
            Console.WriteLine("7. feladat");
            Feladat7(diakok);
            Console.ReadKey();
        }
        static void Feladat1(int[] tomb)
        {
            var q = (from elem in tomb orderby elem ascending select elem).ToArray();
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i] + ", ");
            }
        }
        static void Feladat2(string[] tomb)
        {
            var q = (from elem in tomb orderby elem.Length ascending select elem).ToArray();
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i] + ", ");
            }
        }
        static void Feladat3(int[] tomb)
        {
            var q = (from elem in tomb where (elem % 2 != 0) select elem).ToArray();
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i] + ", ");
            }
        }
        static void Feladat4(string[] tomb)
        {
            var q = (from elem in tomb where (elem.Length == 4) select elem).ToArray();
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i] + ", ");
            }
        }
        static void Feladat5(List<Diak> tomb)
        {
            var q = (from elem in tomb orderby elem.Nev ascending select elem).ToArray();
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i].Nev + ", ");
            }
        }
        static void Feladat6(List<Diak> tomb)
        {
            var q = (from elem in tomb
                     where Prime_e(elem.Kredit)
                     select elem).ToArray();
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i].Nev + ", ");
            }
        }
        static bool Prime_e(int szam)
        {
            if (szam < 2) return false;
            if (szam == 2) return true;
            if (szam % 2 == 0) return false;
            for (int i = 3; i * i <= szam; i += 2)
                if (szam % i == 0) return false;
            return true;
        }
        static void Feladat7(List<Diak> tomb)
        {
            var q = (from elem in tomb where elem.Kredit % 2 == 0 orderby elem.Nev descending select new { Nev = elem.Nev.ToUpper()}).ToArray();
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i].Nev + ", ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSzamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            int szam2 = 0;
            string muvelet = "";
            Console.WriteLine("Kérek 2 számot!");
            Console.WriteLine("Első szám:");
            szam = int.Parse(Console.ReadLine());
            Console.WriteLine("Második szám:");
            szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérek egy műveleti jelet");
            muvelet = Console.ReadLine();
            switch (muvelet)
            {
                case "+":
                    Console.WriteLine("Eredmény: {0}", szam + szam2);
                    break;
                case "-":
                    Console.WriteLine("Eredmény: {0}", szam - szam2);
                    break;
                case ":":
                case "/":
                    Console.WriteLine("Eredmény: {0}", szam / szam2);
                    break;
                case "*":
                    Console.WriteLine("Eredmény: {0}", szam * szam2);
                    break;
            }
            Console.ReadKey();
        }
    }
}

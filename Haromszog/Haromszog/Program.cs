using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    class Kor
    {
        public Kor(int o1, int o2, int R)
        {
            int x = 0, y = 0;
            Console.WriteLine("Kérem a kör koordinátáját!");
            Console.WriteLine("x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("y:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(Adottpont(o1, o2, R, x, y)?"Benne van":"Nincs benne");
        }
        public bool Adottpont(int o1, int o2, int R, int x, int y)
        {
            return (Math.Pow((x - o1), 2) + Math.Pow((y - o2), 2) <= Math.Pow(R, 2));
        }
        public Kor(int R)
        {
            Random r = new Random();
            int o1 = r.Next(0, 80);
            int o2 = r.Next(0, 80);
        }
        public double Ketpontkozottitav(o1,o2)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int o1 = 0, o2 = 0, R = 10;
            Kor valami = new Kor(o1,o2,R);
            Kor valami2 = new Kor(R);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2intwitouthconvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string meh = "123456";
            string mehdouble = "1.2323";
            Console.WriteLine("String: " + meh);
            Console.WriteLine("String double: " + mehdouble);
            int szam = strtoint(meh);
            Console.WriteLine("Első megoldás.. MEH");
            Console.WriteLine("Int: " + szam);
            Console.WriteLine("Második megoldás: "); 
            int szam2 = strtoint2(meh);
            Console.WriteLine("Int: " + szam2);
            double szam3 = strtodouble(mehdouble);
            Console.WriteLine("Harmadik megoldás: ");
            Console.WriteLine("Double: " + szam3);
            Console.ReadKey();
        }
        static int strtoint(string meh)
        {
            int szam = 0;
            foreach (char c in meh)
            {
                szam = szam * 10;
                szam = szam + (c  - '0');
            }
            return szam;
        }
        static int strtoint2(string meh)
        {
            int szam = 0;
            if (meh[0] == '-')
            {
                for (int i = 1; i < meh.Length; i++)
                {
                    szam *= 10;
                    szam += meh[i] - 48;
                }
                szam = 0 - szam;
            }
            else
            {
                for (int i = 0; i < meh.Length; i++)
                {
                    szam *= 10;
                    szam += meh[i] - 48;
                }
            }
            return szam;
        }
        static double strtodouble(string meh)
        {
            double helyiertek = 0.1;
            double szam = 0;
            bool negativ = false;
            bool pont = false;
            for (int i = 0; i < meh.Length; i++)
            {
                if (meh[i] == '-')
                {
                    negativ = true;
                    i++;
                }
                if (meh[i] == '.')
                {
                    pont = true;
                    i++;
                }
                if (pont)
                {
                    szam = szam + (meh[i] -'0') * helyiertek;
                    helyiertek = helyiertek / 10;
                }
                else
                {
                    szam = szam * 10 + meh[i] - '0';
                }
            }
            if (negativ)
            {
                szam = szam * -1;
            }
            return szam;
        }
    }
}

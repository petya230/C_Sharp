using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajlkezelesStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string adat = "asdf5iu4535kjh24klh21m9";
            bool szam;
            int n;
            char[] meh;
            Console.WriteLine("Eredeti string: " + adat);
            StringBuilder adatsb = new StringBuilder(adat);
            for (int i = 0; i < adatsb.Length; i++)
            {
                szam = int.TryParse(adatsb[i].ToString(), out n);
                if (szam)
                {
                    n++;
                    meh = n.ToString().ToCharArray();
                    adatsb[i] = meh[0];
                }
            }
            adat = adatsb.ToString();
            Console.WriteLine("Módosított string: " + adat);
            Console.ReadKey();
        }
    }
}

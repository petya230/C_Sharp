using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringszamnoveles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy valamit.");
            string adat = "abc123defg";// Console.ReadLine();
            string tmp = "";
            char[] szetszed = adat.ToCharArray(), tmp2;
            int szam, atmenet;
            Console.Write("Adat: ");
            Console.Write(adat);
            Console.WriteLine();
            for (int i = 0; i < szetszed.Length; i++)
            {
                szam = 0;
                do
                {
                    if (int.TryParse(szetszed[i].ToString(), out int j))
                    {
                        tmp += szetszed[i].ToString();
                        i++;
                        szam++;
                    }
                } while (int.TryParse(szetszed[i].ToString(), out int x));
                int.TryParse(tmp, out int meh);
                atmenet = meh;
                atmenet++;
                Console.WriteLine(atmenet);
                tmp2 = atmenet.ToString().ToCharArray();
                for (int j = 0; j < tmp2.Length; j++)
                    szetszed[i] = tmp2[j];
            }
            Console.Write("Módosított szám: ");
            foreach(var i in szetszed)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}

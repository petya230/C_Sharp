using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napikavezo
{
    class Program
    {

        static void Main(string[] args)
        {
            string[,] italokNaponta;
            italokNaponta = EladottItalokBekerese();
            Console.WriteLine("Melyik napot szeretnéd megvizsgálni?");
            int index = int.Parse(Console.ReadLine());
            int db = AdottNapiItalokSzama(italokNaponta, index);
            string[] napi = AdottNapotKivalogat(italokNaponta, index);
            Console.ReadKey();
        }
        static int BekerNapokSzama()
        {
            int napokdb;
            Console.WriteLine("Hány nap adatait akarod elmenteni?");
            napokdb = int.Parse(Console.ReadLine());
            return napokdb;
        }
        static string[,] EladottItalokBekerese()
        {
            int napokdb = BekerNapokSzama();
            string[,] italokNaponta = new string[napokdb, 10];
            for (int i = 0; i < italokNaponta.GetLength(0); i++)
            {
                for (int j = 0; j < italokNaponta.GetLength(1); j++)
                {
                    italokNaponta[i, j] = Console.ReadLine();
                }
            }
            return italokNaponta;
        }
        static int AdottNapiItalokSzama(string[,] italokNaponta, int index)
        {
            int db = 0;
            for (int i = 0; i < italokNaponta.GetLength(1); i++)
            {
                db++;
            }
            return db;
        }
        static string[] AdottNapotKivalogat(string[,] italokNaponta, int index)
        {
            string[] napi = new string[italokNaponta.GetLength(1)];
            for (int i = 0; i < italokNaponta.GetLength(1); i++)
            {
                Console.WriteLine(italokNaponta[index, i]);
            }
            return napi;
        }
        static void NapiItalListatRendez(string[,] italokNaponta)
        {

        }
    }
}
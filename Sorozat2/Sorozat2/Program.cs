using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sorozat = new int[] { 2, 2, 3, 3, 3, 4, 4, 5, 5, 5, 5 };
            int N = 2;
            int max = int.MinValue;
            int db = 0;
            for (int i = 0; i < sorozat.Length; i++)
            {
                if (i != sorozat.Length-1)
                {
                    if (sorozat[i] == sorozat[i + 1])
                    {
                        db++;
                    }
                    else
                        db = 0;
                }
                else if(sorozat[i] == sorozat[i - 1])
                {
                    db++;
                }
                if(max < db)
                {
                    max = db;
                }
            }
            Console.WriteLine("db: " + max);
            Console.ReadKey();
        }
    }
}
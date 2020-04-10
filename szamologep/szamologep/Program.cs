using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] szam = {
                "1+2*3-4",
                "1*2+3-4",
                "1+2-3*4",
                "1+2*3-4*5+6",
                "1+2*(3-4)*5+6" };
            for (int i = 0; i < szam.Length; i++)
            {
                string tmp = szam[i];
                Console.WriteLine(i+1 + ". megfejtés: " + szamol(tmp).ToString());
            }
            Console.ReadKey();
        }
        static double szamol(string szam)
        {
            return Convert.ToDouble(new DataTable().Compute(szam, null));
        }
    }
}

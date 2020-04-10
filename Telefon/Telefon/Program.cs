
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon t = new Telefon("+36307976690");
            Telefon t2 = new Telefon("+36205751298");
            HívásNapló h = new HívásNapló();
            t.FigyelőRegisztrál(h);
            t2.FigyelőRegisztrál(h);
            t.EgyenlegFeltöltés(1000);
            t.HívásKezdeményezés(t2);
            Console.ReadKey();
        }
    }
}

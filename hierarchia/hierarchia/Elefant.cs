using System;

namespace hierarchia
{
    internal class Elefant : Lo
    {
        int ormanyhossz;

        public Elefant(string nev) : base(nev)
        {
        }

        public override void AdatokFelvesz()
        {
            base.AdatokFelvesz();
            Console.WriteLine("Add meg az ormány hosszát!");
            ormanyhossz = int.Parse(Console.ReadLine());
        }
        public override void AdatokKiolvas()
        {
            base.AdatokKiolvas();
            Console.WriteLine("Fajtája: " + GetType().Name);
            Console.WriteLine("Súlya: " + suly);
            Console.WriteLine("Ormány hossza: " + ormanyhossz);
        }
    }
}
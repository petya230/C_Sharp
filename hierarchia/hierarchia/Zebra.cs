using System;

namespace hierarchia
{
    internal class Zebra : Lo
    {
        int csikokszama;

        public Zebra(string nev) : base(nev)
        {
        }

        public override void AdatokFelvesz()
        {
            base.AdatokFelvesz();
            Console.WriteLine("Add meg a csíkok számát!");
            csikokszama = int.Parse(Console.ReadLine());
        }

        public override void AdatokKiolvas()
        {
            base.AdatokKiolvas();
            Console.WriteLine("Fajtája: " + GetType().Name);
            Console.WriteLine("Súlya: " + suly);
            Console.WriteLine("Csíkok száma: " + csikokszama);
        }
    }
}
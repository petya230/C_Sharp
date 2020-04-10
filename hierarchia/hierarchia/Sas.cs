using System;

namespace hierarchia
{
    internal class Sas : Vereb
    {
        int repulesiseb;

        public Sas(string nev) : base(nev)
        {
        }

        public override void AdatokFelvesz()
        {
            base.AdatokFelvesz();
            Console.WriteLine("Add meg a repülési sebességet!");
            repulesiseb = int.Parse(Console.ReadLine());
        }
        public override void AdatokKiolvas()
        {
            base.AdatokKiolvas();
            Console.WriteLine("Fajtája: " + GetType().Name);
            Console.WriteLine("Szárnyhossza: " + szarnyhossz);
            Console.WriteLine("Repülési sebessége: " + repulesiseb);
        }
    }
}
using System;

namespace hierarchia
{
    internal class Vereb : Allat
    {
        public int szarnyhossz;

        public Vereb(string nev) : base(nev)
        {
        }

        public override void AdatokFelvesz()
        {
            base.AdatokFelvesz();
            Console.WriteLine("Add meg a szárnyhosszt!");
            szarnyhossz = int.Parse(Console.ReadLine());
        }
        public override void AdatokKiolvas()
        {
            base.AdatokKiolvas();
            Console.WriteLine("Fajtája: " + GetType().Name);
            Console.WriteLine("Szárnyhossza: " + szarnyhossz);
        }
    }
}
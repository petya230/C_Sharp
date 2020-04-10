using System;

namespace hierarchia
{
    internal class Lo : Allat
    {
        public int suly;

        public Lo(string nev) : base(nev)
        {

        }

        public override void AdatokFelvesz()
        {
            base.AdatokFelvesz();
            Console.WriteLine("Add meg a súlyát!");
            suly = int.Parse(Console.ReadLine());
        }
        public override void AdatokKiolvas()
        {
            base.AdatokKiolvas();
            Console.WriteLine("Fajtája: " + GetType().Name);
            Console.WriteLine("Súlya: " + suly);
        }
    }
}
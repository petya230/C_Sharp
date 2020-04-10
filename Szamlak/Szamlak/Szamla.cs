using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamlak
{
    class Szamla : BankiSzolgaltatas
    {
        private int akt_egyenleg;

        public int Akt_engyeleg
        {
            get { return akt_egyenleg; }
            set { Akt_engyeleg = value; }
        }
        public Szamla(Tulajdonos _tul) : base(_tul)
        {

        }
        public void Befizet(int osszeg)
        {
            Akt_engyeleg = Akt_engyeleg + osszeg;
        }
        public bool Kivesz(int osszeg, int keret)
        {
            if (Akt_engyeleg - osszeg > keret)
                return true;
            return false;
        }
    }
}

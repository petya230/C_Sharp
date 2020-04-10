using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    class Telefon : IHívásFigyelő
    {
        public string telefonszám;
        int egyenleg;
        IHívásFigyelő hívásFigyelő;
        public Telefon(string _telefonszám)
        {
            telefonszám = _telefonszám;
        }

        public void HívásFogadás(Telefon forrás)
        {
            if (hívásFigyelő != null)
            {
                hívásFigyelő.BejövőhívásTörtént(forrás, telefonszám);
            }
            
        }
        public void HívásKezdeményezés(Telefon cél)
        {
            if (egyenleg >= 100)
            {
                hívásFigyelő.KimenőhívásTörtént(cél, telefonszám);
                egyenleg -= 100;
            }
            else
            {
                Console.WriteLine("Nincs elegendő egyenleg, a hívás indításához");
            }
        }
        public void BejövőhívásTörtént(Telefon küldő, string forrás_telefonszám)
        {
            
        }

        public void KimenőhívásTörtént(Telefon küldő, string cél_telefonszám)
        {
            
        }
        public void FigyelőRegisztrál(IHívásFigyelő figyelő)
        {
            hívásFigyelő = figyelő;
        }
        public void EgyenlegFeltöltés(int összeg)
        {
            egyenleg += összeg;
        }
    }
}

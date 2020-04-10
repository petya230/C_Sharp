using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    class HívásNapló : IHívásFigyelő
    {
        public void BejövőhívásTörtént(Telefon küldő, string forrás_telefonszám)
        {
            Console.WriteLine(küldő.telefonszám, forrás_telefonszám);
        }

        public void KimenőhívásTörtént(Telefon küldő, string cél_telefonszám)
        {
            Console.WriteLine(küldő.telefonszám, cél_telefonszám);
        }
    }
}

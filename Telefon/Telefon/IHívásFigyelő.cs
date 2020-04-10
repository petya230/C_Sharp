using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    interface IHívásFigyelő
    {
        void BejövőhívásTörtént(Telefon küldő, String forrás_telefonszám);
        void KimenőhívásTörtént(Telefon küldő, String cél_telefonszám);
    }
}

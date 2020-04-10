using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamlak
{
    abstract class BankiSzolgaltatas
    {
        Tulajdonos tulajdonos;

        public BankiSzolgaltatas(Tulajdonos _tul)
        {
            tulajdonos = _tul;
        }
    }
}

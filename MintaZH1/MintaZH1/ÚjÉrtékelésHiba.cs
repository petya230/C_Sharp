using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaZH1
{
    class ÚjÉrtékelésHiba : Kivétel
    {
        int érték;
        public int Érték { get => érték; }
        public ÚjÉrtékelésHiba(Film film, int érték) : base(film)
        {
            this.érték = érték;
        }
    }
}

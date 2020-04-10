using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaZH1
{
    class Kivétel : Exception
    {
        Film film;
        public Film Film { get => film; }
        public Kivétel(Film film)
        {
            this.film = film;
        }
    }
}

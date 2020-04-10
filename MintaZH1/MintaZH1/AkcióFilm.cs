using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaZH1
{
    class AkcióFilm : Film
    {
        int alsó_korhatár;
        public AkcióFilm(int alsó_korhatár, string film_cím, int ár) : base (film_cím, ár)
        {
            this.alsó_korhatár = alsó_korhatár;
        }
        public override void Értékel(int érték)
        {
           
                if (érték > 0 && érték < 5)
                {
                    érték.Add(érték);
                }
        }
    }
}

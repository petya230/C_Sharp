using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaZH1
{
    class Film
    {
        string film_cím;
        int ár;
        List<int> értékelés = new List<int>();
        public string Film_cím { get => film_cím; }
        public int Ár { get => ár; }

        public Film(string film_cím, int ár)
        {
            this.film_cím = film_cím;
            this.ár = ár;
        }
        public virtual void Értékel(int érték)
        {
            if (értékelés.Count() < 10)
            {
                if (érték > 0 && érték < 6)
                {
                    értékelés.Add(érték);
                }
            }
            else { }
        }
    }
}

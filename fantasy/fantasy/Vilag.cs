using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy
{
    class Vilag
    {
        private int terulet;

        public Vilag(int kezdoTerulet = 100)
        {
            if (kezdoTerulet <= 0) kezdoTerulet = 1;
            this.terulet = kezdoTerulet;
        }
        public Vilag() : this(100)
        {
            /* ismétlem a konstruktor logikát
            terulet = 100;
            */
        }
        public int getTerulet() { return terulet; }
        public int tagul()
        {
            terulet += 10;
            Console.WriteLine("Tovább tágult a világ, mérete: " + terulet);
            return terulet;
        }
    }
}

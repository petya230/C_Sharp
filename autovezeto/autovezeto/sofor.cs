using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autovezeto
{
    class Vezeto
    {
        private string nev;
        private bool bentul;

        public string bemutatkozik()
        {
            return "A neve: " + nev;
        }
        public Vezeto(string nev)
        {
            this.nev = nev;
        }
        public bool isBentul() { return bentul; }
        public void setBentul (bool ul)
        {
            bentul = ul;
        }

        public override string ToString()
        {
            return $"név: {nev}, bentül: {bentul}";
        }
    }
}

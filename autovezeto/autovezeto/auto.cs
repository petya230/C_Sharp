using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autovezeto
{
    class Auto
    {
        private string rsz;
        private Vezeto sofor;
        private bool vanSofor;

        public Auto(string rsz)
        {
            this.rsz = rsz;
            vanSofor = false;
        }
        public void beszall(Vezeto vezeto)
        {
            if (!vanSofor &&!vezeto.isBentul())
            {
                sofor = vezeto;
                vezeto.setBentul(true);
                vanSofor = true;
            }
        }
        public void kiszall()
        {
            sofor = null;
        }
        public override string ToString()
        {
            string sn = "Nincs vezető";
            if (sofor != null) sn = sofor.bemutatkozik();
            return $"Rendszám: {rsz}, sofőr: {sn}";
        }
    }
}

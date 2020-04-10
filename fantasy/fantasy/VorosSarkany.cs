using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy
{
    class VorosSarkany : Sarkany
    {
        Random rnd = new Random();
        public int manapont;
        public int tapasztalat;
        public VorosSarkany()
        {
            manapont = 10;
        }
        public void tuz()
        {
            int r = rnd.Next(-1, 2);
            if (manapont >= 3)
            {
                manapont -= 3;
                Console.WriteLine("Tüzet köp, maradék mana: " + manapont);
                if (r == 1)
                {
                    oles();
                }
            }
            else { Console.WriteLine("nincs elég mana"); }
        }
        public void pihen()
        {
            manapont += 5;
            Console.WriteLine("A sárkány pihent, manapontja: " + manapont);
        }
        public void oles()
        {
            tapasztalat += 20;
            Console.WriteLine("A sárkány ölt, így nőtt a tapasztalata, pontja: " + tapasztalat);
        }
        public void Tapasztalat()
        {
            Console.WriteLine("A sárkány tapasztalati pontja: " + tapasztalat);
        }
        public override string ToString()
        {
            //ha az Ős elért dolgai publikusak
            //return $"kor: {this.kor}, mana : {manapont}";
            return base.ToString() + $", mana: { manapont}";
        }
    }
}

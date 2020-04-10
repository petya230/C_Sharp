using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csvBeolvasás
{
    class Beolvas
    {
        public Beolvas(string fajlnev)
        {
            if (fajlnev.Contains("txt"))
            {
                string[] fajl = File.ReadAllLines(fajlnev);
            }
            else if (fajlnev.Contains("csv"))
            {
                string fajl = File.ReadAllText(fajlnev);
            }
        }
    }
}

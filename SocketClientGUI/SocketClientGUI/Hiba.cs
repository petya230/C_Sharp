using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketClientGUI
{
    class Hiba : Exception
    {
        string kiv;

        public Hiba(string kiv)
        {
            this.kiv = kiv;
        }
    }
}

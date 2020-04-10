using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLAN_IP
{
    class IPcim
    {
        //192.168.11.102
        public int Host { get; } //102
        public string Cim { get; } //192.168.11.102
        public string Halozat { get; } //192.168.11

        public IPcim(string sor)
        {
            int p = sor.LastIndexOf('.');
            this.Host = int.Parse(sor.Substring(p + 1));//2));
            this.Halozat = sor.Substring(0, p + 1);
            this.Cim = sor;
        }
        
    }
}

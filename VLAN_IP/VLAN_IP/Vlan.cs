using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLAN_IP
{
    class Vlan
    {
        private string nev;
        private Dictionary<string, int> eszk;
        //vlan.txt-ből: VLAN1
        public Vlan(string nev)
        {
            this.nev = nev;
            eszk = new Dictionary<string, int>();

        }
        //vlan.txt-ből: 767CF59F54C3;102
        public void UjEszkoz(string sor)
        {
            string[] s = sor.Split(';');
            string mac = s[0];
            int host = int.Parse(s[1]);
            eszk.Add(mac, host);
        }
        private int minIP()
        {
            int ip = 255; // int.MaxValue;
            foreach (var eszkoz in eszk.Values)
            {
                if (eszkoz < ip)
                {
                    ip = eszkoz;
                }
            }
            return ip;
        }
        private string MaxMAC()
        {
            int ip = -1; // int.MinValue
            string mac = "";
            foreach (KeyValuePair<string, int> eszkoz in eszk)
            {
                if (eszkoz.Value > ip)
                {
                    ip = eszkoz.Value;
                    mac = eszkoz.Key;
                }
            }
            return mac;
        }
        public override string ToString()
        {
            string ki = nev + "\n";
            ki += "==============================\n";
            foreach (IPcim ipCim in Program.sipcimek)
            {

            }
            foreach  (KeyValuePair<string, int> eszkoz in eszk)
            {
                ki += eszkoz.Key + ", " + eszkoz.Value + "\n";
            }
            ki += "------------------------------\n";
            ki += $"{"Legkisebb",-11}{"Ip: ",5}{minIP(),13}\n";
            ki += $"{"Legnagyobb",-11}{"Mac: ",5}{MaxMAC(),13}\n";

            
            return ki;
        }
    }

}

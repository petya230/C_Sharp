using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VLAN_IP
{
    class Program
    {
        public static List<IPcim> sipcimek = new List<IPcim>();

        static void Main(string[] args)
        {
            string[] ipcim = File.ReadAllLines(@"ip.txt");
            List<IPcim> ipcimek = new List<IPcim>();
            foreach  (string sor in ipcim)
            {
                ipcimek.Add(new IPcim(sor));
                sipcimek.Add(new IPcim(sor));
            }
            //Vlan ujVlan = new Vlan("VLAN3");
            string[] vlan = File.ReadAllLines(@"vlan.txt");
            bool EzNev = true;
            Vlan ujVlan = null;
            List<Vlan> Vlanok = new List<Vlan>();

            foreach (string sor in vlan)
            {
                if (EzNev)
                {
                    ujVlan = new Vlan(sor);
                    Vlanok.Add(ujVlan);
                    EzNev = false;
                }
                else if (!string.IsNullOrEmpty(sor))
                {
                    ujVlan.UjEszkoz(sor);
                }
                else
                {
                    EzNev = true;
                }
                //ujVlan.UjEszkoz(vlan[i]);
                // Console.WriteLine(ujVlan);

            }
            
            //ujVlan.UjEszkoz("3EDF5045DFEF;112");
            //Console.WriteLine(ujVlan);
            foreach (Vlan vlan2 in Vlanok)
            {
                Console.WriteLine(vlan2);
            }
            Console.ReadKey();
        }
    }
}

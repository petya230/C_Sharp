using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHasznalat
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajto a = new Ajto();
            Esernyo e = new Esernyo();

            IKinyithato[] kinyithatoak = new IKinyithato[2];
            kinyithatoak[0] = a;
            kinyithatoak[1] = e;
            foreach (IKinyithato k in kinyithatoak)
            {
                k.kinyit();
            }
            Console.ReadKey();
        }
    }
}

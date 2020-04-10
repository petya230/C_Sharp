using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy
{
    class Sarkany
    {
        private int kor;

        public Sarkany()
        {
            this.kor = 10; // kor;
        }
        public int oregedik()
        {
            kor++;
            Console.WriteLine("Sárkány öregedett, kora: " + kor);
            return kor;
        }
    }
}

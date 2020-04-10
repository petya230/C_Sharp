using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verem
{
    class Verem<T> : kozos<T>
    {
        T[] adatok;
        int index;
        public Verem(int szam) : base(szam)
        {
            index = 0;
            adatok = new T[szam];
        }
        public override void push(T elem) //berak
        {
            if (adatok.Count() > index)
            {
                adatok[index] = elem;
                index++;
            }
            else
                throw new Exception("Nem tudok hozzáadni többet!");
        }
        public override T pop() //Kivesz
        {
            if (index > 0)
            {
                T pop = adatok[index - 1];
                index--;
                return pop;
            }
            else
                throw new Exception("Nincs benne elem!");
        }
    }
}

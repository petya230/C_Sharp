using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verem
{
    class Sor<T> : kozos<T>
    {
        T[] adatok;
        int index;
        int utolsoElem, elemekSzama, elsoElem;

        public Sor(int db) : base(db)
        {
            elemekSzama = 0;
            utolsoElem = 0;
            elsoElem = 0;

            adatok = new T[db];
        }
        public override void push(T elem)
        {
            if (elemekSzama < adatok.Count())
            {
                if (adatok.Count() > utolsoElem)
                {
                    adatok[utolsoElem] = elem;
                    utolsoElem++;
                    elemekSzama++;
                }
                else
                {
                    utolsoElem = 0;
                    adatok[utolsoElem] = elem;
                    utolsoElem++;
                }
            }
            else
                throw new Exception("Teli van a sor!");
        }
        public override T pop()
        {
            if (elemekSzama > 0)
            {
                elemekSzama--;
                T elem = adatok[elsoElem];
                if (elsoElem == adatok.Count() - 1)
                {
                    elsoElem = 0;
                }   
                else
                    elsoElem++;
                return elem;
            }
            else
                throw new Exception("Nincs benne elem");
        }
    }
}

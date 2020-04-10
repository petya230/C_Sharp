using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verem
{
    abstract class kozos<T>
    {
        public kozos(int szam)
        {
        }
        public abstract void push(T elem);
        public abstract T pop();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verem
{
    class Program
    {
        static Sor<string> a;

        static void Main(string[] args)
        {

            Verem<int> v = new Verem<int>(4);
            Sor<int> s = new Sor<int>(4);

            try
            {
                v.push(10);
                Console.WriteLine(v.pop());
                v.push(1);
                v.push(2);
                v.push(3);
                v.push(4);
                Console.WriteLine(v.pop());
                Console.WriteLine(v.pop());
                Console.WriteLine(v.pop());
                Console.WriteLine(v.pop());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("SOR:");
            try
            {
                s.push(1);
                Console.WriteLine(s.pop());
                s.push(2);
                s.push(3);
                s.push(4);
                s.push(5);
                Console.WriteLine(s.pop());
                s.push(6);
                Console.WriteLine(s.pop());
                Console.WriteLine(s.pop());
                s.push(7);
                Console.WriteLine(s.pop());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

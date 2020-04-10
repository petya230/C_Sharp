using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringkezeles
{
    class Program
    {
        static string abc = "abcdefghijklmnopqrstuvwxyz";

        static void Main(string[] args)
        {

            string[] stringek = new string[5];

            for (int i = 0; i < stringek.Length; i++)
            {
                stringek[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < stringek.Length; i++)
            {
                Console.WriteLine(stringek[i]);
            }

            Rendezes(stringek);
            Console.WriteLine();


            for (int i = 0; i < stringek.Length; i++)
            {
                Console.WriteLine(stringek[i]);
            }

            Console.ReadLine();

        }

        static int CharIndex(string s, char a)
        {
            int i = 0;
            while (s[i] != a)
            {
                i++;
            }
            return i;
        }

        static int StringNagyobb(string s1, string s2)
        {
            int i;
            for (i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    break;
                }
            }

            if (CharIndex(abc, s1[i]) < CharIndex(abc, s2[i]))
            {
                return 1;
            }
            else if (CharIndex(abc, s1[i]) > CharIndex(abc, s2[i]))
            {
                return 2;
            }

            return 0;
        }

        static void Csere(int i, int j, string[] s)
        {
            string ideiglenes = s[i];
            s[i] = s[j];
            s[j] = ideiglenes;
        }

        static void Rendezes(string[] s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (StringNagyobb(s[i], s[j]) == 2)
                    {
                        Csere(i, j, s);
                    }
                }
            }
        }
    }
}

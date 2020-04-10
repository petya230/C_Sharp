using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PattogoLabda
{
    class Palya
    {
        static int magassag;
        static bool[,] palya;
        static int poz = 0;
        public Palya(int _magassag)
        {
            magassag = _magassag;
            palya = new bool[20,80];
            palyaFeltolt();
            dobas(magassag);
            Kiir();
            Mozgas();

        }

        static void palyaFeltolt()
        {
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    palya[i, j] = false;
                }
            }
        }
        static void dobas(int magassag)
        {
            palya[magassag, 0] = true;
        }

        static void Kiir()
        {
            Console.Clear();
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    if (palya[i, j] == false)
                        Console.Write(" ");
                    else
                    {
                        Console.Write("o");
                        poz = i;
                    }
                }
                
                Console.WriteLine();
            }
            Thread.Sleep(1000 / poz);

        }
        static void Mozgas()
        {
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    if (palya[i, j] == true)
                    {
                        while (j < palya.GetLength(1)- 1 || (magassag < palya.GetLength(0) || i != palya.GetLength(0))) 
                        {
                            do
                            {
                                palya[i, j] = false;
                                i += 1;
                                j++;
                                palya[i, j] = true;
                                Kiir();
                            } while (i < palya.GetLength(0)-1);
                            magassag = magassag + 5;
                            do
                            {
                                palya[i, j] = false;
                                i--;
                                j++;
                                palya[i, j] = true;
                                Kiir();
                            } while (j < palya.GetLength(1) - 1 && i >= magassag);
                        } 
                    }
                }
            }
        }
    }
}

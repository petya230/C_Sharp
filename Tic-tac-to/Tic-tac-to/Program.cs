using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictacto
{
    class Program
    {

        static string[,] Init(int x)
        {
            string[,] jatek = new string[x, x];
            for (int i = 0; i < jatek.GetLength(0); i++)
            {
                jatek[i, 0] = i.ToString();
                jatek[0, i] = i.ToString();
                for (int j = 1; j < jatek.GetLength(1); j++)
                {
                    jatek[i, j] = "-";
                }
            }
            return jatek;
        }

        static void Main(string[] args)
        {
            int szamlalo = 0;
            bool vege = false;
            int x = 0, y = 0;
            Console.WriteLine("Kérem a pálya méretét!");
            do
            {
                Console.WriteLine("Hányszor hanyas legyen? (minimum 10x10, max 20x20");
                x = int.Parse(Console.ReadLine()) + 1;
            } while (!(x >= 10) && !(x <= 20));

            string[,] jatek = Init(x);
            //Kiir(jatek);
            do
            {
                Kiir(jatek);
                if (szamlalo % 2 == 0)
                {
                    Console.WriteLine("1. Jatékos");
                }
                else
                {
                    Console.WriteLine("2. Jatékos");
                }
                Console.Write("sor: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("oszlop: ");
                y = int.Parse(Console.ReadLine());
                Lep(jatek, x, y, szamlalo % 2 == 0);
                Console.Clear();
                szamlalo++;
                JatekVege(jatek, x, y, szamlalo % 2 == 0);
            } while (JatekVege(jatek, x, y, szamlalo % 2 == 0) != true);
            Console.ReadKey();
        }

        static void Kiir(string[,] jatek)
        {
            for (int i = 0; i < jatek.GetLength(0); i++)
            {
                for (int j = 0; j < jatek.GetLength(1); j++)
                {
                    Console.Write(jatek[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static bool JatekVege(string[,] jatek, int x, int y, bool Jatekos)
        {
            int dbsordby = 0;
            int dbsorx = 0;
            int dboszlopy = 0;
            int dboszlopx = 0;
            for (int i = 0; i < jatek.GetLength(0); i++)
            {
                for (int j = 0; j < jatek.GetLength(1); j++)
                {
                    //sorokX
                    if (jatek[i, j] == "x")
                    {
                        dbsorx++;
                        if (dbsorx >= 5)
                        {
                            if (Jatekos == true)
                            {
                                Console.WriteLine("1. Jatékos nyert!");
                            }
                            return true;
                        }
                    }   
                    else
                    {
                        dbsorx = 0;
                    }
                    //soroky
                    if (jatek[i, j] == "x")
                    {
                        dbsordby++;
                        if (dbsordby >= 5)
                        {
                            if (Jatekos == false)
                            {
                                Console.WriteLine("2. Jatékos nyert!");
                            }
                            return true;
                        }
                    }
                    else
                    {
                        dbsordby = 0;
                    }
                    for (int i2 = 0; i2 < jatek.GetLength(1); i2++)
                    {
                        //oszlopx
                        if (jatek[i2, i2] == "x")
                        {
                            dboszlopx++;
                            if (dboszlopx >= 5)
                            {
                                if (Jatekos == true)
                                {
                                    Console.WriteLine("1. Jatékos nyert!");
                                }
                                return true;
                            }
                        }
                        else
                        {
                            dboszlopx = 0;
                        }
                        //oszlopy
                        if (jatek[i2, i2] == "o")
                        {
                            dboszlopy++;
                            if (dboszlopy >= 5)
                            {
                                if (Jatekos == true)
                                {
                                    Console.WriteLine("2. Jatékos nyert!");
                                }
                                return true;
                            }
                        }
                        else
                        {
                            dboszlopy = 0;
                        }
                    }
                }
            }
            return false;
        }
        static void Lep(string[,] jatek, int x, int y, bool Jatekos)
        {
            if (Jatekos == true)
            {
                Console.WriteLine("1. Jatékos");
                if (jatek[x, y] == "-")
                {
                    jatek[x, y] = "x";
                }
                else
                {
                    Console.WriteLine("itt már van jelölés! Próbáld újra!");
                    Console.Write("sor: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("oszlop: ");
                    y = int.Parse(Console.ReadLine());
                    Lep(jatek, x, y, true);
                }
            }
            else
            {
                Console.WriteLine("2. Jatékos");
                if (jatek[x, y] == "-")
                {
                    jatek[x, y] = "o";
                }
                else
                {
                    Console.WriteLine("itt már van jelölés! Próbáld újra!");
                    Console.Write("sor: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("oszlop: ");
                    y = int.Parse(Console.ReadLine());
                    Lep(jatek, x, y, false);
                }
            }
        }
    }
}

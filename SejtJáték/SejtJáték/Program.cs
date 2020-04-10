using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SejtJáték
{
    class Program
    {
        static int x = 20, y = 20;
        static bool[,] eletter = new bool[x, y];
        static bool[,] tmp_eletter = new bool[x, y];
        static void Main(string[] args)
        {
            Life();
            Console.ReadKey();
        }
        static void alakzat_valaszt()
        {
            Console.WriteLine("Milyen alakzatot szeretnél?\n1.Kereszt\n2.Glider\n3.Small Explorer\n4.Exploder");
            int beker = int.Parse(Console.ReadLine());
            switch (beker)
            {
                case 1:
                    eletter[9, 10] = true;
                    eletter[10, 9] = true;
                    eletter[10, 10] = true;
                    eletter[10, 11] = true;
                    eletter[11, 10] = true;
                    break;
                case 2:
                    eletter[9, 10] = true;
                    eletter[10, 11] = true;
                    eletter[11,11] = true;
                    eletter[11, 9] = true;
                    eletter[11, 10] = true;
                    break;
                case 3:
                    eletter[9, 10] = true;
                    eletter[10, 9] = true;
                    eletter[10,10] = true;
                    eletter[10,11] = true;
                    eletter[11, 9] = true;
                    eletter[11, 11] = true;
                    eletter[12,10] = true;
                    break;
                case 4:
                    eletter[9, 8] = true;
                    eletter[9, 10] = true;
                    eletter[9, 12] = true;
                    eletter[10, 8] = true;
                    eletter[10, 12] = true;
                    eletter[11, 8] = true;
                    eletter[11, 12] = true;
                    eletter[12, 8] = true;
                    eletter[12, 12] = true;
                    eletter[13, 8] = true;
                    eletter[13, 10] = true;
                    eletter[13, 12] = true;
                    break;
                default:
                    Console.WriteLine("Hülye vagy...");
                    alakzat_valaszt();
                    break;
            }
        }
        static void Life()
        {
            palya_feltolt();
            int kor = 0;
            alakzat_valaszt();
            Console.Clear();
            do
            {
                kiir();
                lepes();
                masol();
                kor++;
                Thread.Sleep(250);
            } while (true);
        }
        static void palya_feltolt()
        {
            for (int i = 0; i < eletter.GetLength(0); i++)
            {
                for (int j = 0; j < eletter.GetLength(1); j++)
                {
                    eletter[i, j] = false;
                    tmp_eletter[i, j] = false;
                }
            }
        }
        static void kiir()
        {
            Console.Clear();
            for (int i = 0; i < eletter.GetLength(0); i++)
            {
                for (int j = 0; j < eletter.GetLength(1); j++)
                {
                    if (eletter[i, j] == false)
                        Console.Write(" ");
                    if (eletter[i, j] == true)
                        Console.Write("0");
                }
                Console.WriteLine();
            }
        }
        static void lepes()
        {
            int Szamolt_Szomszed = 0;
            for (int i = 0; i < eletter.GetLength(0); i++)
            {
                for (int j = 0; j < eletter.GetLength(1); j++)
                {
                    Szamolt_Szomszed = szomszed_szamlalo(i, j);

                    if (eletter[i, j] == true)
                    {
                        if (Szamolt_Szomszed < 2 || Szamolt_Szomszed > 3)
                        {
                            tmp_eletter[i, j] = false;
                        }
                        else
                            tmp_eletter[i, j] = true;
                        
                    }
                    if (eletter[i, j] == false)
                    {
                        if (Szamolt_Szomszed == 3)
                        {
                            tmp_eletter[i, j] = true;
                        }
                    }

                    /*if (Szamolt_Szomszed == 3)
                    {
                        tmp_eletter[j, i] = true;
                    }
                    else if (Szamolt_Szomszed == 2 && eletter[j,i] == true)
                    {
                        tmp_eletter[j, i] = true;
                    }
                    else
                    {
                        tmp_eletter[j, i] = false;
                    }*/
                }
            }
        }
        static int szomszed_szamlalo(int i, int j)
        {
            int szomszedok = 0;
            if (i > 0 && j > 0 && eletter[i - 1, j - 1] == true) //bal felette
                szomszedok++;
            if (i > 0 && eletter[i - 1, j] == true) //balra
                szomszedok++;
            if (i > 0 && j < eletter.GetLength(1) - 1 && eletter[i - 1, j + 1] == true) //balra lent
                szomszedok++;
            if (j > 0 && eletter[i, j - 1] == true) //felette
                szomszedok++;
            if (j < eletter.GetLength(1) - 1 && eletter[i, j + 1] == true) //alatta
                szomszedok++;
            if (i < eletter.GetLength(0) - 1 && j > 0 && eletter[i + 1, j - 1] == true) //jobb fent
                szomszedok++;
            if (i < eletter.GetLength(0) - 1 && eletter[i + 1, j] == true) //jobbra
                szomszedok++;
            if (i < eletter.GetLength(0) - 1 && j < eletter.GetLength(1) - 1 && eletter[i + 1, j + 1] == true) //jobbra lent
                szomszedok++;
            return szomszedok;
        }
        static void masol()
        {
            for (int i = 0; i < eletter.GetLength(0); i++)
            {
                for (int j = 0; j < eletter.GetLength(1); j++)
                {
                    eletter[i, j] = tmp_eletter[i, j];
                }
            }
        }
    }
}
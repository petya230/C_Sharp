using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace memoriajatek
{
    class Program
    {
        static void Main(string[] args)
        {
            int jatekos1 = 0, jatekos2 = 0;
            string abc = "abcdefghijklmnopabcdefghijklmnop";
            char[] parok = abc.ToCharArray();
            char[,] parok2d = new char[5, 9];
            string[,] kartyak = new string[5, 9];
            int szamlalo = 2;
            //init
            kever(parok);
            jatekpalya(kartyak);
            Konvertálás(parok, parok2d);
            //init
            Console.WriteLine("Csalás: ");
            Kiir(parok2d);
            Console.WriteLine();
            Console.WriteLine();
            do
            {
                Kiir(kartyak);
                Thread.Sleep(2000);
                Console.Clear();
                if (szamlalo % 2 == 0)
                {
                    Console.WriteLine("1. Jatékos");
                }
                else if (szamlalo % 2 != 0)
                {
                    Console.WriteLine("2. Jatékos");
                }
                Lepes(parok2d, kartyak, szamlalo, jatekos1, jatekos2);
                Kiir(kartyak);
                Console.Clear();
                szamlalo++;
            }while(JatekVege(kartyak, jatekos1, jatekos2) != true);

            Console.ReadKey();
        }
        static void kever(char[] parok)
        {
            Random rnd = new Random();
            for (int k = 0; k < parok.Length; k++)
            {
                for (int i = 0; i < parok.Length; i++)
                {
                    int x = rnd.Next(i, parok.Length);
                    char tmp = parok[i];
                    parok[i] = parok[x];
                    parok[x] = tmp;
                }
            }
        }
        static void jatekpalya(string[,] tomb)
        {
            for (int i = 1; i < tomb.GetLength(0); i++)
            {
                tomb[i, 0] = i.ToString();
                
                for (int j = 1; j < tomb.GetLength(1); j++)
                {
                    tomb[0, j] = j.ToString();
                    tomb[i, j] = "\u25A0";
                }
            }
        }
        static void Kiir(char[] parok)
        {
            for (int i = 0; i < parok.Length; i++)
            {
                Console.Write(parok[i] + ", ");
            }
        }
        static void Kiir(string[,] tomb)
        {
            for(int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write(tomb[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Kiir(char[,] tomb)
        {
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write(tomb[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Konvertálás(char[] tomb, char[,] parok2d)
        {
            int x = 0;
            for (int i = 1; i < parok2d.GetLength(0); i++)
            {
                for (int j = 1; j < parok2d.GetLength(1); j++)
                {
                    parok2d[i, j] = tomb[x];
                    x++;
                }
            }
        }
        static void Lepes(char[,] parok2d, string[,] kartyak, int szamlalo, int jatekos1, int jatekos2)
        {
            int i, j;
            for (int x = 0; x < 2; x++)
            {
                Kiir(kartyak);
                Console.WriteLine("Sor: ");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("Oszlop: ");
                j = int.Parse(Console.ReadLine());
                kartyak[i, j] = parok2d[i, j].ToString();
                int tmpi = i;
                int tmpj = j;
                Kiir(kartyak);
                Console.WriteLine("Sor: ");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("Oszlop: ");
                j = int.Parse(Console.ReadLine());
                kartyak[i, j] = parok2d[i, j].ToString();
                Kiir(kartyak);
                Thread.Sleep(2000);
                Console.Clear();
                if ((i != tmpi) && (j != tmpj))
                {

                    if (kartyak[i, j] == kartyak[tmpi, tmpj])
                    {
                        if (szamlalo % 2 == 0)
                        {
                            Console.WriteLine("Ez egy pár!");
                            jatekos1++;
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Ez egy pár!");
                            jatekos2++;
                            Thread.Sleep(1000); 
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Rossz pár!");
                        kartyak[i, j] = "\u25A0";
                        kartyak[tmpi, tmpj] = "\u25A0";
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Ugyan azt a karaktert válaszotttad!!!");
                    kartyak[i, j] = "\u25A0";
                    Lepes(parok2d, kartyak, szamlalo, jatekos1, jatekos2);
                }
            }
        }
        static bool JatekVege(string[,] kartyak, int jatekos1, int jatekos2)
        {
            int lapokszama = 0;
            for (int i = 1; i < kartyak.GetLength(0); i++)
            {
                for (int j = 1; j < kartyak.GetLength(1); j++)
                {
                    if (kartyak[i,j] == "\u25A0")
                    {
                        lapokszama++;
                    }
                    else
                    {
                        lapokszama = 0;
                    }
                }
            }
            if ((lapokszama == 32) && (jatekos1 != 0) && (jatekos2 != 0))
            {
                if (jatekos1 > jatekos2)
                {
                    Console.WriteLine("Első játékos nyert! Ennyi ponttal: " +jatekos1);
                    return true;
                }
                else
                {
                    Console.WriteLine("Második játékos nyert! Ennyi ponttal: " + jatekos2);
                    return true;
                }
            }
            return false;
        }
    }
}

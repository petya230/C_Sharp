using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Binaris_Ora
{
    class Program
    {

        static bool[,] ido_bin = new bool[4, 6];
        static string ido_txt_beolv = File.ReadAllText("ora.txt");
        static string[,] ido_txt = new string[4, 6];
        static string mp_str;
        static string perc_str;
        static string ora_str;

        static void txt_beolv()
        {
            int sorszam = ido_txt_beolv.Length;
            for (int i = ido_txt.GetLength(0)-1; i >=0 ; i--)
            {
                for (int j = ido_txt.GetLength(1)-1; j >=0; j--)
                {
                    if (ido_txt_beolv[sorszam - 1].ToString() != "\n" && ido_txt_beolv[sorszam - 1].ToString() != "\r")
                    {
                        ido_txt[i, j] = ido_txt_beolv[sorszam - 1].ToString();

                    }
                    else
                        j++;

                    sorszam--;
                }
            }
        }
        static void Main(string[] args)
        {
            feltolt();
            Console.WriteLine("1. TXT-ből az óra\r\n2. jelenlegi óra");
            int valaszt = int.Parse(Console.ReadLine());
            switch (valaszt)
            {
                case 1:
                    Console.Clear();
                    txt_beolv();
                    string[] ido_re = bin_to_time().Split(':');
                    int ora_txt = int.Parse(ido_re[0]);
                    int perc_txt = int.Parse(ido_re[1]);
                    int mp_txt = int.Parse(ido_re[2]);
                    do
                    {
                        if (mp_txt == 59)
                        {
                            perc_txt++;
                            mp_txt = 0;
                        }
                        else if (perc_txt == 59)
                        {
                            ora_txt++;
                            perc_txt = 0;
                        }
                        else if (ora_txt == 24)
                        {
                            ora_txt = 0;
                        }
                        feltolt();
                        ido(ora_txt, perc_txt, mp_txt);
                        kiir();
                        Console.WriteLine(" " + ora_str + ":" + perc_str + ":" + mp_str);
                        mp_txt++;
                        Thread.Sleep(1000);
                        Console.Clear(); 
                    } while (true);
                case 2:
                    do
                    {
                        int ora = DateTime.Now.Hour;
                        int perc = DateTime.Now.Minute;
                        int mp = DateTime.Now.Second;
                        feltolt();
                        ido(ora, perc, mp);
                        kiir();
                        Console.WriteLine();
                        Console.WriteLine(" " + ora_str + ":" + perc_str + ":" + mp_str);
                        Thread.Sleep(500);
                        Console.Clear();
                    } while (true);
            }
            Console.ReadKey();
        }
        static void ido(int ora, int perc, int mp)
        {
            int bit = 8;
            int mp_resz;
            int perc_resz;
            int ora_resz;
            for (int j = ido_bin.GetLength(1) - 1; j >= 0; j--)
            {
                switch (j)
                {
                    case 5:
                        bit = 8;
                        mp_str = mp + "";
                        if (mp_str.Length == 1)
                            mp_str = "0" + mp_str;
                        mp_resz = int.Parse(mp_str[1].ToString());
                        for (int i = 0; i < ido_bin.GetLength(0); i++)
                        {
                            if (mp_resz - bit >= 0 && bit != 0)
                            {
                                ido_bin[i, j] = true;
                                mp_resz -= bit;
                            }

                            bit /= 2;
                        }
                        break;
                    case 4:
                        bit = 8;
                        mp_str = mp + "";
                        if (mp_str.Length == 1)
                            mp_str = "0" + mp_str;
                        mp_resz = int.Parse(mp_str[0].ToString());
                        for (int i = 0; i < ido_bin.GetLength(0); i++)
                        {
                            if (mp_resz - bit >= 0 && bit != 0)
                            {
                                ido_bin[i, j] = true;
                                mp_resz -= bit;
                            }

                            bit /= 2;
                        }
                        break;
                    case 3:
                        bit = 8;
                        perc_str = perc + "";
                        if (perc_str.Length == 1)
                            perc_str = "0" + perc_str;
                        perc_resz = int.Parse(perc_str[1].ToString());
                        for (int i = 0; i < ido_bin.GetLength(0); i++)
                        {
                            if (perc_resz - bit >= 0 && bit != 0)
                            {
                                ido_bin[i, j] = true;
                                perc_resz -= bit;
                            }

                            bit /= 2;
                        }
                        break;
                    case 2:
                        bit = 8;
                        perc_str = perc + "";
                        if (perc_str.Length == 1)
                            perc_str = "0" + perc_str;
                        perc_resz = int.Parse(perc_str[0].ToString());
                        for (int i = 0; i < ido_bin.GetLength(0); i++)
                        {
                            if (perc_resz - bit >= 0 && bit != 0)
                            {
                                ido_bin[i, j] = true;
                                perc_resz -= bit;
                            }

                            bit /= 2;
                        }
                        break;
                    case 1:
                        bit = 8;
                        ora_str = ora + "";
                        if (ora_str.Length == 1)
                            ora_str = "0" + ora_str;
                        ora_resz = int.Parse(ora_str[1].ToString());
                        for (int i = 0; i < ido_bin.GetLength(0); i++)
                        {
                            if (ora_resz - bit >= 0 && bit != 0)
                            {
                                ido_bin[i, j] = true;
                                ora_resz -= bit;
                            }

                            bit /= 2;
                        }
                        break;
                    case 0:
                        bit = 8;
                        ora_str = ora + "";
                        if (ora_str.Length == 1)
                            ora_str = "0" + ora_str;
                        ora_resz = int.Parse(ora_str[0].ToString());
                        for (int i = 0; i < ido_bin.GetLength(0); i++)
                        {
                            if (ora_resz - bit >= 0 && bit != 0)
                            {
                                ido_bin[i, j] = true;
                                ora_resz -= bit;
                            }
                            bit /= 2;
                        }
                        break;
                }
            }
        }
        static void feltolt()
        {
            for (int i = 0; i < ido_bin.GetLength(0); i++)
            {
                for (int j = 0; j < ido_bin.GetLength(1); j++)
                {
                    ido_bin[i, j] = false;
                }
            }
        }
        static void kiir()
        {
            for (int i = 0; i < ido_bin.GetLength(0); i++)
            {
                for (int j = 0; j < ido_bin.GetLength(1); j++)
                {
                    if (ido_bin[i, j] == false)
                        Console.Write("- ");
                    else
                        Console.Write("x ");
                }
                Console.WriteLine();
            }
        }
        static string bin_to_time( )
        {
            int bit = 8;
            string ora = "";
            string perc = "";
            string ms = "";
            int szamlalo = 0;
            for (int j = 0 ; j <= ido_txt.GetLength(1); j++)
            {
                switch (j)
                {
                    case 5:
                        bit = 8;
                        szamlalo = 0;
                        for (int i = 0; i < ido_txt.GetLength(0); i++)
                        {
                            if (ido_txt[i, j] == "x")
                            {
                                szamlalo += bit;
                            }
                            else
                            {
                                szamlalo += 0;
                            }
                            bit /= 2;
                        }
                        ms += szamlalo + "";
                        break;
                    case 4:
                        bit = 8;
                        szamlalo = 0;
                        for (int i = 0; i < ido_txt.GetLength(0); i++)
                        {
                            if (ido_txt[i, j] == "x")
                            {
                                szamlalo += bit;
                            }
                            else
                            {
                                szamlalo += 0;
                            }
                            bit /= 2;
                        }
                        ms = szamlalo + "";
                        break;
                    case 3:
                        bit = 8;
                        szamlalo = 0;
                        for (int i = 0; i < ido_txt.GetLength(0); i++)
                        {
                            if (ido_txt[i, j] == "x")
                            {
                                szamlalo += bit;
                            }
                            else
                            {
                                szamlalo += 0;
                            }
                            bit /= 2;
                        }
                        perc += szamlalo + "";
                        break;
                    case 2:
                        bit = 8;
                        szamlalo = 0;
                        for (int i = 0; i < ido_txt.GetLength(0); i++)
                        {
                            if (ido_txt[i, j] == "x")
                            {
                                szamlalo += bit;
                            }
                            else
                            {
                                szamlalo += 0;
                            }
                            bit /= 2;
                        }
                        perc = szamlalo + "";
                        break;
                    case 1:
                        bit = 8;
                        szamlalo = 0;
                        for (int i = 0; i < ido_txt.GetLength(0); i++)
                        {
                            if (ido_txt[i, j] == "x")
                            {
                                szamlalo += bit;
                            }
                            else
                            {
                                szamlalo += 0;
                            }
                            bit /= 2;
                        }
                        ora += szamlalo + "";
                        break;
                    case 0:
                        bit = 8;
                        szamlalo = 0;
                        for (int i = 0; i < ido_txt.GetLength(0); i++)
                        {
                            if (ido_txt[i, j] == "x")
                            {
                                szamlalo += bit;
                            }
                            else
                            {
                                szamlalo += 0;
                            }
                            bit /= 2;
                        }
                        ora = szamlalo + "";
                        break;
                }
            }
            return ora + ":" + perc + ":" + ms;
        }
    }
}

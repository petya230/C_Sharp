using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Operátorkereső
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] operandusok_txt = File.ReadAllLines("operandusok.txt");
            List<string> hiba = new List<string>();
            List<string> megoldott = new List<string>();
            List<string> txt = new List<string>();
            List<string> hiba_txt = new List<string>();
            Console.Write("2. feladat: Kérek 2 operandust és az eredményt!\r\nAz adatokat pontosvesszővel válassza el! [1;1;1;]:");
            string beker = Console.ReadLine();
            string[] szetbont;
            double[] muvelet = new double[3];
            if (beker == "")
                beker = "1;1;1";
            szetbont = beker.Split(';');
            for (int i = 0; i < szetbont.Length; i++)
            {
                if (double.TryParse(szetbont[i], out muvelet[i])) { }
                else
                {
                    hiba.Add("Hiba az adatsorban: " + szetbont[0] + ";" + szetbont[1] + ";" + szetbont[2]);
                }
            }
            megoldas(szetbont, megoldott);
            Console.WriteLine("3-5 feladatok:");
            kiir(megoldott);
            Console.WriteLine();
            kiir(hiba);
            operandusok_txt_met(operandusok_txt, txt, hiba_txt);
            Console.WriteLine("6. feladat:");
            kiir(hiba_txt);
            Console.WriteLine();
            Console.WriteLine("7. feladat:");
            kiir_9_elem(txt);
            fajlba_iras(txt);
            Console.ReadKey();
        }

        static void megoldas(string[] szetbont, List<string> megoldott)
        {
            double[] szamok = new double[3];
            for (int i = 0; i < szetbont.Length; i++)
            {
                szamok[i] = double.Parse(szetbont[i]);
            }
            if (szamok[0] + szamok[1] == szamok[2])
            {
                megoldott.Add(szamok[0] + " + " + szamok[1] + " = " + szamok[2]);
            }
            if (szamok[0] - szamok[1] == szamok[2])
            {
                megoldott.Add(szamok[0] + " - " + szamok[1] + " = " + szamok[2]);
            }
            if (szamok[0] * szamok[1] == szamok[2])
            {
                megoldott.Add(szamok[0] + " * " + szamok[1] + " = " + szamok[2]);
            }
            if (szamok[0] / szamok[1] == szamok[2])
            {
                megoldott.Add(szamok[0] + " / " + szamok[1] + " = " + szamok[2]);
            }
        }
        static void kiir(List<string> kiir)
        {
            foreach (var sorok in kiir)
            {
                Console.WriteLine(sorok);
            }
        }
        static void operandusok_txt_met(string[] fajl, List<string> txt, List<string> hiba_txt)
        {
            for (int i = 0; i < fajl.Length; i++)
            {
                szetbont_met(fajl[i], txt, hiba_txt);
            }
        }
        static void szetbont_met(string adat, List<string> txt, List<string> hiba_txt)
        {
            string[] szetbont = adat.Split(';');
            double[] muvelet = new double[3];
            int ellenoriz = 0;
            for (int i = 0; i < szetbont.Length; i++)
            {
                if (!(szetbont.Length < 3))
                {


                    try
                    {
                        if (double.TryParse(szetbont[i], out muvelet[i]))
                        {
                            ellenoriz++;
                        }
                        else
                        {
                            txt.Add("Hiba az adatsorban: " + szetbont[0] + ";" + szetbont[1] + ";" + szetbont[2]);
                            hiba_txt.Add("Hiba az adatsorban: " + szetbont[0] + ";" + szetbont[1] + ";" + szetbont[2]);
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        string hiba = "Hiba az adatsorban: ";
                        for (int j = 0; j < szetbont.Length; j++)
                        {
                            hiba += szetbont[j] + ";";
                        }
                        txt.Add(hiba);
                        hiba_txt.Add(hiba);
                    }
                }
                else
                {
                    string hiba = "Hiba az adatsorban: ";
                    for (int j = 0; j < szetbont.Length; j++)
                    {
                        hiba += szetbont[j] + ";";
                    }
                    txt.Add(hiba);
                    hiba_txt.Add(hiba);
                }
            }
            if (ellenoriz == 3)
                megoldas_txt(szetbont, txt, hiba_txt);
        }
        static void megoldas_txt(string[] szetbont, List<string> txt, List<string> hiba_txt)
        {
            double[] szamok = new double[3];
            int szamol = 0;
            try
            {
                for (int i = 0; i < szetbont.Length; i++)
                {

                    szamok[i] = double.Parse(szetbont[i]);
                }
                if (szamok[0] + szamok[1] == szamok[2])
                {
                    txt.Add(szamok[0] + " + " + szamok[1] + " = " + szamok[2]);
                    szamol++;
                }
                if (szamok[0] - szamok[1] == szamok[2])
                {
                    txt.Add(szamok[0] + " - " + szamok[1] + " = " + szamok[2]);
                    szamol++;
                }
                if (szamok[0] * szamok[1] == szamok[2])
                {
                    txt.Add(szamok[0] + " * " + szamok[1] + " = " + szamok[2]);
                    szamol++;
                }
                if (szamok[0] / szamok[1] == szamok[2])
                {
                    txt.Add(szamok[0] + " / " + szamok[1] + " = " + szamok[2]);
                    szamol++;
                }
            }
            catch (IndexOutOfRangeException)
            {
                string hiba = "Hiba az adatsorban: ";
                for (int j = 0; j < szetbont.Length; j++)
                {
                    hiba += szetbont[j] + ";";
                }
                if (txt[txt.Count - 1] != hiba)
                {
                    txt.Add(hiba);
                    hiba_txt.Add(hiba);
                }
            }
            if (szamol == 0)
            {
                txt.Add("Nem értelmezhető: " + szamok[0] + " / " + szamok[1] + " = " + szamok[2]);
            }
        }
        static void kiir_9_elem(List<string> txt)
        {
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine(txt[i]);
            }
        }
        static void fajlba_iras(List<string> txt)
        {
            string elemek = "";
            for (int i = 0; i <= txt.Count-1; i++)
            {
                elemek += txt[i] + "\r\n";
            }
            File.WriteAllText("kifejezesek.txt", elemek);
        }
    }
}

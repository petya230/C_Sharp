using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaiToDecimalis
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 3999;
            string decTorom = "";
            romaiTOdec(decTorom, szam);
            string romai = "IIIIX";
            romai.ToUpper();
            //szam = int.Parse(Console.ReadLine());
            decTOromai(romai);
            Console.ReadKey();
        }
        static void romaiTOdec(string decTorom, int szam)
        {
            while (szam > 0)
            {
                if (szam - 1000 >= 0)
                {
                    decTorom += "M";
                    szam -= 1000;
                }
                else if (szam - 900 >= 0)
                {
                    decTorom += "CM";
                    szam -= 900;
                }
                else if (szam - 500 >= 0)
                {
                    decTorom += "D";
                    szam -= 500;
                }
                else if (szam - 400 >= 0)
                {
                    decTorom += "CD";
                    szam -= 400;
                }
                else if (szam - 100 >= 0)
                {
                    decTorom += "C";
                    szam -= 100;
                }
                else if (szam - 90 >= 0)
                {
                    decTorom += "XC";
                    szam -= 90;
                }
                else if (szam - 50 >= 0)
                {
                    decTorom += "L";
                    szam -= 50;
                }
                else if (szam - 40 >= 0)
                {
                    decTorom += "XL";
                    szam -= 40;
                }
                else if (szam - 10 >= 0)
                {
                    decTorom += "X";
                    szam -= 10;
                }
                else if (szam - 9 >= 0)
                {
                    decTorom += "IX";
                    szam -= 9;
                }
                else if (szam - 5 >= 0)
                {
                    decTorom += "V";
                    szam -= 5;
                }
                else if (szam - 4 >= 0)
                {
                    decTorom += "IV";
                    szam -= 4;
                }
                else if (szam - 1 >= 0)
                {
                    decTorom += "I";
                    szam -= 1;
                }
            }
            kiirDec(decTorom);
        }
        static void decTOromai(string romai)
        {
            int tmp = 0;
            for (int i = 0; i < romai.Length; i++)
            {
                switch (romai[i])
                {
                    case 'I':
                        {
                            if (romai.Length == i)
                            {
                                tmp++;
                            }
                            else
                            {

                                if (i != romai.Length - 1 && (romai[i + 1] == 'V' || romai[i + 1] == 'X'))
                                {
                                    tmp = help((romai[i] + "" + romai[i + 1]), tmp);
                                    i++;
                                }
                                else
                                    tmp++;
                            }
                            break;
                        }
                    case 'V':
                        {
                            tmp += 5;
                            break;
                        }
                    case 'X':
                        {
                            if (romai.Length == 1)
                            {
                                tmp += 10;
                            }
                            else
                            {
                                if (i != romai.Length - 1 && (romai[i + 1] == 'L' || romai[i + 1] == 'C'))
                                {
                                    tmp = help((romai[i] + "" + romai[i + 1]), tmp);
                                    i++;
                                }
                                else
                                    tmp += 10;
                            }
                            break;
                        }
                    case 'L':
                        {

                            tmp += 50;
                            break;
                        }
                    case 'C':
                        {
                            if (romai.Length == 1)
                            {
                                tmp += 100;
                            }
                            else
                            {
                                if (i != romai.Length - 1 && (romai[i + 1] == 'D' || romai[i + 1] == 'M'))
                                {
                                    tmp = help((romai[i] + "" + romai[i + 1]), tmp);
                                    i++;
                                }
                                else
                                    tmp += 100;
                            }
                            break;
                        }
                    case 'D':
                        {
                            tmp += 500;
                            break;
                        }
                    case 'M':
                        {
                            tmp += 1000;
                            break;
                        }
                }
            }
            kiirRomai(tmp);
        }
        static void kiirRomai(int dec)
        {
            Console.WriteLine("Ez lett a rómaiszámodból: " + dec);
        }
        static void kiirDec(string romai)
        {
            Console.WriteLine("Ez lett a decimális számodból: " + romai);
        }
        static int help(string seged, int romaiH)
        {
            switch(seged)
            {
                case "IV":
                    {
                        romaiH += 4;
                        break;
                    }
                case "IX":
                    {
                        romaiH += 9;
                        break;
                    }
                case "XL":
                    {
                        romaiH += 40;
                        break;
                    }
                case "XC":
                    {
                        romaiH += 90;
                        break;
                    }
                case "CD":
                    {
                        romaiH += 400;
                        break;
                    }
                case "CM":
                    {
                        romaiH += 900;
                        break;
                    }
            }
            return romaiH;
        }
    }
}

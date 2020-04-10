using System;
using System.IO;
using System.Collections.Generic;

namespace tukorevek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> evszamok = new List<int>();
            int kezdoev = 22901999;
            int vegzoev = 30000000;
            
            bool tukor = true;

            do
            {
                if ((kezdoev.ToString()[4] == '0') && (kezdoev.ToString()[5] == '0'))
                {
                    kezdoev++;
                }
                else
                {
                    if ((int.Parse((kezdoev.ToString()[4] + "" + kezdoev.ToString()[5])) <= int.Parse("12")) && (int.Parse((kezdoev.ToString()[6] + "" + kezdoev.ToString()[7]))) <= DateTime.DaysInMonth(int.Parse((kezdoev.ToString()[0] + "" + kezdoev.ToString()[1] + "" + kezdoev.ToString()[2] + "" + kezdoev.ToString()[3])), int.Parse(kezdoev.ToString()[4] + "" + kezdoev.ToString()[5])))
                    {
                        for (int i = 0; i < kezdoev.ToString().Length; i++)
                        {
                            int j = kezdoev.ToString().Length - i - 1;
                            if ((kezdoev.ToString()[i] == kezdoev.ToString()[j]) && (tukor != false))
                            {
                                tukor = true;
                            }
                            else
                            {
                                tukor = false;
                                i = kezdoev.ToString().Length;
                            }

                        }
                    }
                    else
                    {
                        tukor = false;
                    }
                    if (tukor == true)
                    {
                        Console.WriteLine("talált: " + kezdoev);
                        evszamok.Add(kezdoev);
                        File.AppendAllText("lista.txt", kezdoev.ToString() + "\n");
                    }
                    tukor = true;
                    kezdoev++;
                }
            } while (kezdoev <= vegzoev);
        }
    }
}

using System;
using System.Collections.Generic;

namespace hierarchia
{
    class Program
    {
        static List<Allat> allatok = new List<Allat>();

        static void Main(string[] args)
        {
            int menu;
            int allat;
            string allatnev;
            bool kilep = false;
            do
            {
                menu = 0;
                allat = 0;

                allatnev = "";

                Console.WriteLine("Válassz!");
                Console.WriteLine("1. Állatok felvételek");
                Console.WriteLine("2. Felvett állatok neveinek kilistázása");
                Console.WriteLine("3. Allat kikeresese név alapján");
                Console.WriteLine("4. Kilépés");
                menu = int.Parse(Console.ReadLine());
                switch ( menu )
                {
                    case 1:
                        Console.WriteLine("Neve: ");
                        allatnev = Console.ReadLine();
                        Console.WriteLine("Milyen állatot szeretnél hozzáadni?");
                        Console.WriteLine("1. Ló");
                        Console.WriteLine("2. Zebra");
                        Console.WriteLine("3. Elefánt");
                        Console.WriteLine("4. Vereb");
                        Console.WriteLine("5. Sas");
                        allat = int.Parse(Console.ReadLine());
                        switch ( allat )
                        {
                            case 1:
                                allatok.Add(new Lo(allatnev));
                                break;
                            case 2:
                                allatok.Add(new Zebra(allatnev));
                                break;

                            case 3:
                                allatok.Add(new Elefant(allatnev));
                                break;

                            case 4:
                                allatok.Add(new Vereb(allatnev));
                                break;

                            case 5:
                                allatok.Add(new Sas(allatnev));
                                break;
                        }
                        allatok[allatok.Count - 1].AdatokFelvesz();
                        break;

                    case 2:
                        kilistaz();
                        break;

                    case 3:
                        Console.WriteLine("Kérem az állat nevét: ");
                        string keres = Console.ReadLine();
                        Kereses(keres);
                        break;
                    case 4:
                        kilep = true;
                        break;
                }
            } while ( !kilep );
        }

        static void kilistaz()
        {
            foreach ( var allat in allatok )
            {
                Console.WriteLine(allat.GetNev());
            }
        }

        static void Kereses(string keres)
        {
            int i = 0;
            foreach ( var allat in allatok )
            {
                if ( allat.GetNev().ToLower() == keres.ToLower() )
                {
                    // allat.GetType().Name();
                    allatok[i].AdatokKiolvas();
                    break;
                }
                i++;
            }
        }
    }
}
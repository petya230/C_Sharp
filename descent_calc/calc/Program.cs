using System;

namespace calc
{
    class Program
    {
        static float iLevel, tLevel, slope, TOD, ROD, decrate, Gs, IAS, iFL, eFL, Winds;
        static int selspeed = 0;

        static string sType = "S";
        static string[] typeofm = { " Calculate Rate Of Descent Using: ", "1: GROUND SPEED", "2: TAS -Under Development", "3: MACH", "5: Back" };
        static float todcalc(float iLevel, float tLevel, float slope)
        {
            if (iLevel > 999)
            {
                TOD = (int)((iLevel - tLevel) / 100) / slope;
                return TOD;
            }
            else
            {
                TOD = (int)(iLevel - tLevel) / slope;
                return TOD;
            }

        }

        static float Rodcalcgs(float decrate, float Gs)
        {
            ROD = (decrate * Gs);
            sType = " (GS)";
            return ROD;
        }

        static float Rodcalctas(float decrate, float IAS, float iFL, float eFL, float Winds)
        {
            ROD = decrate * ((IAS + ((iFL / eFL) / 2)) - Winds);
            sType = "(TAS)";
            return ROD;
        }

        static float RodcalcMach(float decrate, float Gs)
        {
            ROD = decrate * Gs * 1000;
            sType = "(MACH)";
            return ROD;
        }
        static void Main(string[] args)
        {

            System.Console.Title = "TOD Calculator (OAMS)";


            int Selection = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("TOP OF DESCENT: " + TOD + " NM");
                Console.WriteLine("RATE OF DESCENT: " + ROD + " FT/Min" + sType);
                string[] opsel = { " ", "1: CALCULATE TOP OF DESCENT", "2: CALCULATE RATE OF DESCENT", "5: Exit", "", "", "", "", "", "Not For Real World Navigation" };
                foreach (string line in opsel)
                    Console.WriteLine(line);
                Selection = int.Parse(Console.ReadLine());
                switch (Selection)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("TOD CALCULATOR");
                        Console.WriteLine("Glide Slope � Degrees:");
                        slope = float.Parse(Console.ReadLine());
                        Console.WriteLine("Initial Level (Numbers Only): ");
                        iLevel = float.Parse(Console.ReadLine());
                        Console.WriteLine("Target Level (Numbers Only): ");
                        tLevel = float.Parse(Console.ReadLine());
                        todcalc(iLevel, tLevel, slope);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            foreach (string line in typeofm)
                                Console.WriteLine(line);
                            selspeed = int.Parse(Console.ReadLine());
                            switch (selspeed)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Descent Rate (%) (5.2% AVG): ");
                                    decrate = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Ground Speed (Knots): ");
                                    Gs = float.Parse(Console.ReadLine());
                                    Rodcalcgs(decrate, Gs);
                                    selspeed = 5;
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Descent Rate(%) (5.2% AVG || 3.0 DEG ): ");
                                    decrate = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Indicated Air Speed (Knots): ");
                                    IAS = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Initial FL: ");
                                    iFL = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Expected FL: ");
                                    eFL = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Wind (Kts): ");
                                    Winds = float.Parse(Console.ReadLine());
                                    Rodcalctas(decrate, IAS, iFL, eFL, Winds);
                                    selspeed = 5;
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Descent angle (�): ");
                                    decrate = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Mach: ");
                                    Gs = float.Parse(Console.ReadLine());
                                    RodcalcMach(decrate, Gs);
                                    selspeed = 5;
                                    break;
                                    break;
                            } while (selspeed != 5) ;
                        } while (selspeed != 5);
                        break;

                }
            } while (Selection != 5);

        }
    }
}
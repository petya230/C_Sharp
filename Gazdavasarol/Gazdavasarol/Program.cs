using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazdavasarol
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("7 és 11 fejű sárkányok");

            for (int het = 1; het <= 19; het++)
            {
                for (int tizenegy = 1; tizenegy <= 19; tizenegy++)
                {
                    if (7 * het + 11 * tizenegy == 145)
                    {
                        Console.WriteLine($"Hetfejű: {het}db, Tizenegy fejű: {tizenegy}db");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("100 arany és 100 állat");
            double s = 3.5;
            double k = 4.0 / 3;
            double j = 0.5;
            int kor = 0;

            for (int x = 1; x < 98; x++)
            {
                for (int y = 3; y < 98; y+=3)
                {
                    for (int z = 1; z < 98; z++)
                    {
                        if ((100 == x + y + z) && (100 == x * s + y * k + z * j))
                        {
                            kor++;
                            Console.WriteLine($"Sertés: {x}db, Kecske: {y}db, Juh {z}db");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

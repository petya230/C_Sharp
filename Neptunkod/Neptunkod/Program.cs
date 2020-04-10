using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptunkod
{
    class Program
    {
        static void Main(string[] args)
        {
            string karakterek = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char neptunkodkar;
            string neptunkod = "       ";
            char[] neptun = neptunkod.ToCharArray();
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                neptunkodkar = karakterek[r.Next(0, karakterek.Length)];
                neptun[i] = (char)neptunkodkar;
            }
            neptunkod = new string(neptun);
            Console.WriteLine(neptunkod);
            Console.ReadKey();
        }
    }
}

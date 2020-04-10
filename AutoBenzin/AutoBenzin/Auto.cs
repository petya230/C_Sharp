using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBenzin
{
    class Auto
    {
        public bool vanBenzin;
        public bool motorJar;

        public Auto()
        {
            vanBenzin = true;
            motorJar = false;
        }
        public void Ment()
        {
            if (vanBenzin)
            {
                vanBenzin = false;
                Console.WriteLine("Az autó megérkezett, de kifogyott a benzin!");
            }
            else
            {
                Console.WriteLine("nincs benzin, nem érkezett meg...");
            }
        }
        public void Tankol()
        {
            if (!motorJar)
            {
                vanBenzin = true;
            }
            else { Console.WriteLine("Jár a motor! Kérlek állítsd le, hogy tankolhass"); }
        }
        public void SetMotor()
        {
            bool indit = true;
            bool leallit = false;

            if(!motorJar)
            {
                motorJar = indit;
            }
            else
            {
                motorJar = leallit;
            }
        }
    }
}

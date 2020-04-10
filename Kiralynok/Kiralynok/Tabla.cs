using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kiralynok
{
    class Tabla
    {
        char[,] T;
        char UresCella;
        
        public Tabla(char UresCella)
        {
            T = new char[8, 8];
            this.UresCella = UresCella;
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[i, j] = UresCella;
                }
            }
        }
        public void Megjelenit()
        {
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    Console.Write(T[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void Elhelyez(int N)
        {
            Random rnd = new Random();
            int sor, oszlop;
            for (int x = 0; x < N; x++)
            {
                sor = rnd.Next(T.GetLength(0));
                oszlop = rnd.Next(T.GetLength(1));
                if (T[sor, oszlop] == UresCella)
                {
                    T[sor, oszlop] = 'K';
                }
                else
                    x--;
            }
        }
        public bool UresSor(int sor)
        {
            for (int i = 0; i < T.GetLength(1); i++)
            {
                if (T[sor, i] == 'K')
                {
                    return false;
                }
            }
            return true;
        }
        public bool UresOszlop(int oszlop)
        {
            for (int i = 0; i < T.GetLength(1); i++)
            {
                if (T[i, oszlop] == 'K')
                {
                    return false;
                }
            }
            return true;
        }

        public void UresOszlopokSzama()
        {
            int uresoszlop = 0;
            for (int i = 0; i < T.GetLength(1); i++)
            {
                if(UresOszlop(i))
                {
                    uresoszlop++;
                }
            }
            Console.WriteLine("Oszlopok: " + uresoszlop);
        }
        public void UresSorokSzama()
        {
            int uressor = 0;
            for (int i = 0; i < T.GetLength(0); i++)
            {
                if (UresSor(i))
                {
                    uressor++;
                }
            }
            Console.WriteLine("Sorok: " + uressor);
        }
        public void FajlBaIr()
        {
            string sor = "";
            if (File.Exists("tablak64.txt"))
            {
                File.Delete("tablak64.txt");
            }
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    sor = sor + T[i, j] + " ";
                }
                File.AppendAllText("tablak64.txt", sor + "\r\n");
                sor = "";
            }
            File.AppendAllText("tablak64.txt", "---------------------" + "\r\n");
        }               //metódus

    }
}

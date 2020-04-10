using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTavolsag
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 9; // int.Parse(Console.ReadLine());
            int[,] matrix = new int[N,N];
            feltolt(matrix);
            kiir(matrix);
            Console.WriteLine();
            tavolsag(matrix, N);
            Console.ReadKey();
        }

        static void feltolt(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = 0;
                }
            }
        }

        static void kiir(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void tavolsag(int[,] matrix, int N)
        {
            N--;
            int meh = 0;
            int meh2 = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    int min = N;
                    if(min > i)
                    {
                        min = i;
                    }
                    if(min > j)
                    {
                        min = j;
                    }
                    if (min > N-i)
                    {
                        min = N - i;
                    }
                    if(min > N-j)
                    {
                        min = N - j;
                    }
                    matrix[i, j] = min;
                }
            }
            kiir(matrix);
        }
    }
}

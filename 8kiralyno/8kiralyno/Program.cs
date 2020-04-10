using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking
{
    class Program
    {
        const int N = 8;

        // Megvizsgáljuk, hogy a már lerakott királynők nincsenek-e ütésben a most lerakni kívánt királynő vanalaiban.
        // Igaz értéket adunk vissza, ha az x,y koordinátába le lehet rakni egy királynőt, és hamisat ha nem.
        static bool Megengedett(bool[,] tabla, int x, int y)
        {
            for ( int i = 0; i <= x; i++ )
            {
                // Ha balra tőle van királynő  vagy Ha balra fel van királynő   vagy   ha balra le van királynő
                if ( tabla[i, y] || ( i <= y && tabla[x - i, y - i] ) || ( y + i < N && tabla[x - i, y + i] ) )
                {  // Ha van már királynő valamelyik irányba, akkor hamis értéket adunk vissza
                    return false;
                }
            }
            return true;
        }

        // A megadott táblába az x-edig oszloptól kezdve megpróbálunk királynőket elhelyezni.
        // Igaz értéket ad vissza, ha találtunk egy jó megoldást.
        static bool MegoldastTalal(bool[,] tabla, int x)
        {
            // Végignézzük az x-edik oszlopot, hogy hová tudnánk királynőt elhelyezni
            for ( int y = 0; y < N; y++ )
            {
                // Az x,y koordinátára lehet királynőt tenni ?
                if ( Megengedett(tabla, x, y) )
                {  // Ha igen, akkor teszünk egy királynőt az x,y koordinátába
                    tabla[x, y] = true;

                    // Ha ez az utolsó oszlop volt   vagy   ha nem az utolsó volt akkor a következő oszlopba folytatjuk a keresést
                    // és ha igaz értékkel tér vissza, akkor sikerrel járt
                    if ( x == N - 1 || MegoldastTalal(tabla, x + 1) )
                    {  // Ha végére értünk vagy a mélyebb keresés sikerrel járt, akkor igaz értéket adunk vissza
                        return true;
                    }

                    // Ha nem sikerült a keresés, akkor a királynőt levesszük a tábláról
                    tabla[x, y] = false;

                    // Majd folytatjuk a keresést a következő y koordinátával
                }
            }

            // Ha egyik y koordináta sem járt sikerrel, akkor az x-edik oszlopba nem lehet királynőt elhelyezni.
            return false;
        }

        static void Main(string[] args)
        {
            bool[,] tabla = new bool[N, N];

            // Elindítjuk a keresést a nulladik oszloppal
            if ( MegoldastTalal(tabla, 0) )
            { // Ha talált egy jó megoldást, akkor azt kirajzoljuk
                for ( int i = 0; i < N; i++ )
                {
                    for ( int j = 0; j < N; j++ )
                    {
                        Console.Write(tabla[j, i] ? "|X" : "| ");
                    }
                    Console.WriteLine("|");
                }
            }
            else
            {  // Ha nem találtunk jó megoldást, akkor kiírjuk, hogy nincs megoldás
                Console.WriteLine("Nem talál megoldást n = " + N + "-ra/re");
            }

            Console.ReadKey(true);
        }
    }
}
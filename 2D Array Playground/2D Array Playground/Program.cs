using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] array2D = new int[5, 5];
            int numberToAdd=1;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] =numberToAdd;
                    numberToAdd++;
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine("\n");    
            }
            Console.WriteLine("\n");


            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 3;
            for (int j = 0;j < array2D.GetLength(1); j++) 
            {
                Console.Write(array2D[nRow,j]+" ");
            }
            Console.WriteLine("\n" + "\n");

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.Write(array2D[i,nColumn] + " ");
            }
            Console.WriteLine("\n" + "\n");
            //Diagonala hlavni
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.Write(array2D[i,i]+" ");
            }
            Console.WriteLine("\n" + "\n");
            //Diagonala vedlejsi
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.Write(array2D[i,4-i]+" ");
            }
            Console.WriteLine("\n" +"\n");

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst, yFirst, xSecond, ySecond,swap;
            xFirst = 0;
            yFirst = 0; 
            xSecond = 4;
            ySecond = 4;
            swap = array2D[xFirst,yFirst];
            array2D[xFirst,yFirst] = array2D[xSecond,ySecond];
            array2D[xSecond, ySecond] = swap;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            swap = array2D[xFirst, yFirst];//vrati puvodni hodnoty do tabulky
            array2D[xFirst, yFirst] = array2D[xSecond, ySecond];
            array2D[xSecond, ySecond] = swap;

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 4;
            int[]arrayRow= new int[array2D.GetLength(0)];
            for (int i = 0;i< array2D.GetLength(0); i++)
            {
                arrayRow[i] = array2D[mRowSwap,i];
                array2D[mRowSwap,i] = array2D[nRowSwap,i];
                array2D[nRowSwap, i] = arrayRow[i];
            }
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < array2D.GetLength(0); i++)//vrati puvodni hodnoty do tabulky
            {
                arrayRow[i] = array2D[mRowSwap, i];
                array2D[mRowSwap, i] = array2D[nRowSwap, i];
                array2D[nRowSwap, i] = arrayRow[i];
            }

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 4;
            int[] arrayCol = new int[array2D.GetLength(0)];
            for (int i = 0; i < array2D.GetLength(1); i++)
            {
                arrayCol[i] = array2D[i,mColSwap];
                array2D[i,mColSwap] = array2D[i,nColSwap];
                array2D[i,nColSwap] = arrayCol[i];
            }
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < array2D.GetLength(1); i++)//vrati puvodni hodnoty do tabulky
            {
                arrayCol[i] = array2D[i, mColSwap];
                array2D[i, mColSwap] = array2D[i, nColSwap];
                array2D[i, nColSwap] = arrayCol[i];
            }

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.

            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.


            Console.ReadKey();
        }
    }
}

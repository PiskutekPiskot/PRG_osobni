using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            double[] numsArray = new double[5];
            for (int i = 0; i < 5; i++)
            { 
                numsArray[i] = Convert.ToDouble(Console.ReadLine());
            }
            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            foreach (int num in numsArray)Console.WriteLine(num);
            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            double sum=0;
            foreach (int num in numsArray) sum += num;
            Console.WriteLine("sum is "+sum);
            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            double average=sum/5;
            Console.WriteLine("average is "+average);
            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            double max = numsArray[0];
            foreach (int num in numsArray)if (num > max) { max = num;}
            Console.WriteLine("max is "+max);
            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            double min = numsArray[0];
            foreach (int num in numsArray) if (num < min) { min = num; }
            Console.WriteLine("min is "+min);
            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            Console.WriteLine("Input a number");
            double findNum = Convert.ToDouble(Console.ReadLine());
            int index=Array.IndexOf(numsArray, findNum);
            if (true)
            {
                Console.WriteLine("input number isn't in your array");
            }
            else
            {
                Console.WriteLine("index of input number is "+index);
            }
            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rnd =new Random();
            int[] numsRandomArray = new int[100];
            for (int i = 0; i < 100; i++)
            {
                numsRandomArray[i] = rnd.Next(10);
            }
            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            for (int i = 0; i < 10; i++)
            {
                foreach (int count in numsRandomArray) if (count==i)
                    {
                        counts[i]++;
                    }          
            }
            foreach (int num in counts) Console.WriteLine("there are "+num+ '"'+Array.IndexOf(counts,num)+'"' +"in the big array.");
            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] countsBackwards = new int[10];
            for (int i = 9; i > -1; i--)
            {
                countsBackwards[i] = counts[9-i];
            }
            foreach (int num in countsBackwards) Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}

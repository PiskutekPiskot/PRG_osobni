using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RecursionPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Nacteme cislo n, pro ktere budeme pocitat jeho faktorial a n-ty prvek Fibonacciho posloupnosti.
            int factorial = Factorial(n); // Prvni zavolani pro vypocet faktorialu, ulozeni do promenne factorial.
            int fibonacci = Fibonacci(n); // Prvni zavolani pro vypocet Fibonacciho posloupnosti, ulozeni do promenne fibonacci.
            Console.WriteLine($"Pro cislo {n} je faktorial {factorial} a {n}. prvek Fibonacciho posloupnosti je {fibonacci}"); // Vypsani vysledku uzivateli.
            Console.ReadKey();
        }

        static int Factorial(int n)
        {
            int output =1;
            if (n!=1)
            {
                output = n * Factorial(n - 1);
                return output;
            }
            return output;
        }

        static int Fibonacci(int n)
        {
            int output = 0;
            if (n==1) { return 0;}
            if (n==2) { return 1;} 
            output = Fibonacci(n - 1) + Fibonacci(n - 2);
            return output;
            //0,1,1,2,3,5,8,13,21,34,55...
        }
    }
}

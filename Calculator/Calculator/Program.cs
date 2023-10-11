using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pokud se budes chtit na neco zeptat a zrovna budu pomahat jinde, zkus se zeptat ChatGPT ;) - https://chat.openai.com/
             * 
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Mozna rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */


            /* while (true)
             {
                 Console.WriteLine("napiš první číslo");
                 double a = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine("napiš číselnou operaci (+,-,*,/)");
                 string operace = Console.ReadLine();
                 Console.WriteLine("napiš druhé číslo");
                 double b = Convert.ToDouble(Console.ReadLine());
                 double vysledek = 0;
                 switch (operace)
                 {
                     case "+":
                         vysledek = a + b;
                         break;
                     case "-":
                         vysledek = a - b;
                         break;
                     case "*":
                         vysledek = a * b;
                         break;
                     case "/":
                         vysledek = a / b;
                         break;
                     case "^":
                         vysledek = Math.Pow(a,b);
                         break;
                 }
                 Console.WriteLine("výsledek je " + vysledek +'\n');
             }*/
            Console.WriteLine("write an equation (only with one operator)");
            string input = Console.ReadLine();
            string number = "";
            string Operator = "";
            double output = 0;
            List<string> operators = new List<string>();
            List<string> viableOperators = new List<string> { "+", "-", "*", "/", "^", };
            List<double> numbers = new List<double>();
            for (int i = 0; i < input.Length; i++)//Rozdělí vztup na operatory a čísla.
            {
                if (char.IsDigit(input[i]))
                {
                    number = number + input[i];
                    if (viableOperators.Contains(Operator))
                    {
                        operators.Add(Operator);
                        Operator = "";
                    }


                }
                else
                {

                    Operator = Operator + input[i];

                    if (Double.TryParse(number, out double res)) { numbers.Add(Convert.ToDouble(number)); }
                    else { break; }
                    number = "";
                }

            }
            operators.IndexOf("*");
            numbers.Add(Convert.ToDouble(number));
            operators.Add(Operator);
            for (int i = 0; i < operators.Count; i++)
            {
                switch (operators[i])
                {
                    case "*":
                        output = numbers[0] * numbers[i + 1];
                        numbers[0] = output;
                        break;
                    case "/":
                        output = numbers[0] / numbers[i + 1];
                        numbers[0] = output;
                        break;
                    case "-":
                        output = numbers[0] - numbers[i + 1];
                        numbers[0] = output;
                        break;
                    case "+":
                        output = numbers[0] + numbers[i + 1];
                        numbers[0] = output;
                        break;
                    case "^":
                        output = Math.Pow(numbers[0], numbers[i + 1]);
                        numbers[0] = output;
                        break;
                }
            }


            operators.ForEach(Console.WriteLine);
            numbers.ForEach(Console.WriteLine);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
    
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
            Console.WriteLine("this calculator can use +,-,*,/,^" + '\n' + "you can also use the variable x or ans" + '\n');
            double output = 0;
            int numberOfRepetitions = 0;
            while (true)
            {
                Console.WriteLine("write an equation (No Brackets)");
                string input = Console.ReadLine().Replace(".", ",").ToLower();//Zmeni tecky na carky v pripade, ze uzivatel zada desetinne misto za teckou.
                string number = "";
                string Operator = "";
                int duplicateOps = 0;
                List<string> operators = new List<string>();
                List<string> viableOperators = new List<string> { "^", "/", "*", "-", "+" };//Seznam moznych operaci v poradi ciselnych operaci.
                List<double> numbers = new List<double>();
                if (input.Contains("x"))//Zjisti jestli priklad obsahuje neznamou x.
                {
                    Console.WriteLine("input value of x");
                    if (double.TryParse(Console.ReadLine(), out double x))//zkontroluje zda je zadana hodnota double.
                    {
                        input = input.Replace("x", x.ToString());//Vymeni "x" v priklade za zadanou hodnotu x.
                    }
                }
                if (input.Contains("ans"))
                {
                    if (numberOfRepetitions > 0)
                    {
                        input = input.Replace("ans", output.ToString());
                    }
                    else
                    {
                        Console.WriteLine("ans is not defined");
                    }
                }
                if (double.TryParse(input, out double result))//Pokud uzivatel zada pouze cislo bez zadneho operatora, tak je zadane cislo vysledek.
                {
                    output = result;
                }

                for (int i = 0; i < input.Length; i++)//Cyklus rozdeli priklad na cisla a na operace.
                {
                    if (char.IsDigit(input[i]) || input[i] == ',' || input[i] == '.')
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
                        if (Double.TryParse(number, out double res))
                        {
                            numbers.Add(Convert.ToDouble(number));
                        }
                        else { break; }
                        number = "";
                    }
                }
                if (number != "")//zjisti jestli zadany priklad dava smysl.
                {
                    numbers.Add(Convert.ToDouble(number));
                    operators.Add(Operator);
                    foreach (string OperatorOrder in viableOperators)//Cyklus probehne pro kazdou operaci v seznamu operaci, ale pokazdy se zmeni OperatorOrder na dalsi operaci. 
                    {
                        foreach (string dupe in operators)
                        {
                            if (dupe == OperatorOrder)
                            {
                                duplicateOps++;
                            }
                        }
                        for (int i = 0; i < duplicateOps; i++)//opakuje vypocet pro operatora vic krat pro pripad ze ho priklad obsahuje vic krat
                        {
                            int y = operators.IndexOf(OperatorOrder);//Zjisti na jakem miste se v seznamu operatoru nachazi OperatorOrder
                            if (y != -1)
                            {
                                switch (OperatorOrder)
                                {
                                    case "*":
                                        output = numbers[y] * numbers[y + 1]; break;
                                    case "/":
                                        output = numbers[y] / numbers[y + 1]; break;
                                    case "+":
                                        output = numbers[y] + numbers[y + 1]; break;
                                    case "-":
                                        output = numbers[y] - numbers[y + 1]; break;
                                    case "^":
                                        output = Math.Pow(numbers[y], numbers[y + 1]); break;
                                }
                                numbers[y + 1] = output; //Po spocteni casti rovnice vymeni spoctenou cast za vysledek
                                numbers.RemoveAt(y);
                                operators.RemoveAt(y);
                            }
                        }
                    }
                    Console.WriteLine("the answer is: " + output);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                numberOfRepetitions++;
            }
            Console.ReadKey();
        }
    }
}
    
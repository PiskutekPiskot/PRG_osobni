using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu.
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem kamen-nuzky-papir.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy skore obou
             *
             * Opakuj tolikrat, kolik kol chces hrat:
             * {
             *      Dokud uzivatel nezada vstup spravne:
             *      {
             *          - nacitej vstup od uzivatele
             *      }
             *      
             *      - vygeneruj s pomoci rng.Next() nahodny vstup pocitace
             *      
             *      Pokud vyhral uzivatel:
             *      {
             *          - informuj uzivatele, ze vyhral kolo
             *          - zvys skore uzivateli o 1
             *      }
             *      Pokud vyhral pocitac:
             *      {
             *          - informuj uzivatele, ze prohral kolo
             *          - zvys skore pocitaci o 1
             *      }
             *      Pokud byla remiza:
             *      {
             *          - informuj uzivatele, ze doslo k remize
             *      }
             * }
             * 
             * - informuj uzivatele, jake mel skore on/a a pocitac a kdo vyhral.
             */

            Random rnd = new Random(); //instance tridy Random pro generovani nahodnych cisel
            Console.WriteLine("How many rounds do you want to play?");
            int rounds = Convert.ToInt32(Console.ReadLine());
            int playerPoints = 0;
            int computerPoints = 0;
            string computerTurn = "";
            string input = "";
            List<string> RPS = new List<string>() {"rock","paper","scissors"};
            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine("enter: rock, paper, scissors");
                while (true)
                { 
                    input = Console.ReadLine().ToLower();
                    if (RPS.Contains(input)) {break;}
                    else { Console.WriteLine("Wrong input, try again."); } 
                }
                computerTurn = RPS[rnd.Next(3)];
                if (computerTurn == input)
                {
                    Console.WriteLine("Computer chose " + computerTurn + " You TIED!");
                }    
               else
                {
                    if ((computerTurn=="rock" && input=="paper") || (computerTurn == "paper" && input == "scissors") || (computerTurn == "scissors" && input == "rock"))
                    {
                        Console.WriteLine("Computer chose "+computerTurn+" You WON!");
                        playerPoints++;
                    }
                    else 
                    {
                        Console.WriteLine("Computer chose " + computerTurn + " You LOST!");
                        computerPoints++; 
                    }
                    
                }
            }
            Console.WriteLine("You won " + playerPoints + " times and the computer won " + computerPoints + " times.");
            Console.ReadKey(); //Aby se nam to hnedka neukoncilo
        }
    }
}

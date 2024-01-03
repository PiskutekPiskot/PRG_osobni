using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GameTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<string>> screen = new Dictionary<int, List<string>>();
            List<string> lvl1 = FillList();
            List<string> lvl2 = FillList();
            List<string> lvl3 = FillList();
            List<string> lvl4 = FillList();
            List<string> lvl5 = FillList();
            List<string> lvl6 = FillList();
            List<string> lvl7 = FillList();
            List<string> lvl8 = FillList();
            List<string> lvl9 = FillList();
            List<string> ground = new List<string>();
            for (int i = 0; i < Console.WindowWidth + 2; i++)
            {
                ground.Add("_");
            }
            screen.Add(1, lvl1);
            screen.Add(2, lvl2);
            screen.Add(3, lvl3);
            screen.Add(4, lvl4);
            screen.Add(5, lvl5);
            screen.Add(6, lvl6);
            screen.Add(7, lvl7);
            screen.Add(8, lvl8);
            screen.Add(9, lvl9);
            screen.Add(0, ground);


            for (int i = Console.WindowWidth - 1; i >= 0; i--)
            {
                Console.Clear();
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(screen[j]);
                }
                ground[i] = "/\\";
                ground[i + 1] = "_";
                for (int k = 1; k < Console.WindowWidth + 1; k++)
                {
                    Console.Write(ground[k]);
                }
                Thread.Sleep(50);
            }
            Console.ReadKey();
            int a = 10;
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key.Equals(ConsoleKey.UpArrow)) Jump();
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("");
                }
                Console.Write("O");
            }
        }
        static void Jump()
        {
            int a = 10;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {

                }
                Console.WriteLine("");
            }
        }
        static List<string>  FillList()
            {
            List<string> lvl = new List<string>();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                lvl.Add("");
            }
            return lvl;
            }
    }
        
}

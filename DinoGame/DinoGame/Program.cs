using System;

namespace DinoGame
{
    internal class Program
    {
        public static int score;
        public static int highScore=0;
        static void Main(string[] args)
        {
            StartGame(); 
        }
        static void StartGame()
        {
            score = 0;
            Console.WriteLine("Tap any key to start");
            Screen.PrintScreen(Screen.CreateFinalArray());
            Console.ReadKey();
            Screen.RunScreen();
        }
    }
}
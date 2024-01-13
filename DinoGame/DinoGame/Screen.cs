using System;
namespace DinoGame
{
	public static class Screen
	{
        static int a = 15;
        static int b = 80;
        public static int speedCycle = 0;
        public static int screenSpeed = 1;
        static char[,] screenArray = CreateScreenArray(); 
        public static void PrintScreen(char[,] finalArray)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b-10; j++)
                {
                    Console.Write(finalArray[i, j]);
                }
                Console.Write('\n');
            }
        }
        public static void RunScreen()//hlavní cyklus, který po intervalech vypisuje měnící se pole
        {
            char[,] finalArray;
            while (true)
            {
                if (Console.KeyAvailable && !Character.inJump)//Načtení vztupu jsem okopíroval
                {
                    ConsoleKey pressedKey = Console.ReadKey().Key;
                    if (pressedKey.Equals(ConsoleKey.Spacebar))
                    {
                        Character.Jump();
                    }
                }
                finalArray = CreateFinalArray();
                PrintScreen(finalArray);
                if (Character.DeathTest())
                {
                    Character.Death();
                    break;
                }
                Thread.Sleep(55 -(screenSpeed*5));
                if (speedCycle==50+(screenSpeed*5))
                {
                    screenSpeed++;
                    speedCycle = 0;
                }
                if (screenSpeed< 9)
                {
                    speedCycle++;
                }
                Program.score++;
                Console.Clear();
            }
            
        }
        public static char[,] CreateScreenArray()
        { 
            char[,] screenArray = new char[a, b];
            for (int i = 0; i < a-1; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    screenArray[i, j] = ' ';
                }
            }
            for (int i = 0; i < b; i++)
            {
                screenArray[a-1, i] = '▀';
            }

            return screenArray;
        }
        public static char[,] CreateFinalArray() //Dá dohromady do jednoho pole panáčka a bodlaky  
        {
            Random rnd = new Random();
            char[,] finalArray = new char[a,b];
            char[,] character = Character.CreateCharacter();
            string currentObstacle = Obstacles.currentObstacle;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b ; j++)
                {
                    finalArray[i, j] = screenArray[i, j];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    finalArray[i + 10 - Character.yChar, j + 6] = character[i, j];
                }
            }
            if (Obstacles.obstacleOnScreen)
            {
                Obstacles.xCurrentObstacle-=2;
                if (Obstacles.xCurrentObstacle==0)
                {
                    Obstacles.obstacleOnScreen = false;
                }
            }
            else
            {
                currentObstacle = Obstacles.GenerateObstacle();
                Obstacles.xCurrentObstacle = 70;
            }
            for (int i = 0; i < currentObstacle.Length; i++)
            {
                finalArray[13, Obstacles.xCurrentObstacle+i] = currentObstacle[i];
            }
            return finalArray;
        }
    }
}



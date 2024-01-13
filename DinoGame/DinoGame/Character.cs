using System;
namespace DinoGame
{
	public class Character
    {
        public static bool inJump = false;
        public static int characterAnimationFrame = 0;
        public static int jumpFrame;
        static bool characterAnimation = true;
        static string character1 = "▄█████▄█  █  █▀█████▀  █ ▀  ";
        static string character2 = "▄█████▄█  █  █▀█████▀  ▀ █  ";
        public static int yChar = 0;
        public static char[,] CreateCharacter()
        {
            char[,] character = new char[4, 7];
            if (inJump)
            {
                switch (jumpFrame) // posouvá panáčka nahoru a dolu při výskoku
                {
                    case 1: yChar = 2; break;
                    case 2: yChar = 3; break;
                    case 3: yChar = 4; break;
                    case 4: yChar = 4; break;
                    case 5: yChar = 5; break;
                    case 6: yChar = 5; break;
                    case 7: yChar = 5; break;
                    case 8: yChar = 4; break;
                    case 9: yChar = 4; break;
                    case 10: yChar = 3; break;
                    case 11: yChar = 2; break;
                    case 12: yChar = 0; inJump = false; break;
                }
                jumpFrame++;
            }
            else
            {
                yChar = 0;
            }
            if (characterAnimation)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        character[i, j] = character1[i * 7 + j];
                    }
                }
                if (characterAnimationFrame==4)
                {
                    characterAnimation = false;
                    characterAnimationFrame = 0;
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        character[i, j] = character2[i * 7 + j];
                    }
                }
                if (characterAnimationFrame == 4)
                {
                    characterAnimation = true;
                    characterAnimationFrame = 0;
                }
            }
            characterAnimationFrame++;
            return character;
        }
        public static void Jump()
        {
            inJump = true;
            jumpFrame = 1;
            Console.Beep();
        }
        public static void Death()// obrazovka po smrti a vyresetování některých proměnných
        {
            if (Program.score>Program.highScore)
            {
                Program.highScore = Program.score;
            }
            Console.Clear();
            Console.Write("Game Over"+'\n'+"score "+ Program.score+'\n'+ "high score "+Program.highScore+'\n');
            Thread.Sleep(2000);
            Console.WriteLine("Tap any key to start");
            Console.ReadKey();
            Console.Clear();
            Obstacles.currentObstacle = "";
            Obstacles.obstacleOnScreen = false;
            Program.score = 0;
            Screen.screenSpeed = 1;
            Screen.speedCycle = 0;
            Screen.RunScreen();

        }
        public static bool DeathTest() // zkontroluje jestli nemá být panáček mrtvý
        { 
            bool dead = false;
            if
                (
                    Obstacles.xCurrentObstacle + Obstacles.currentObstacle.Length < 12  &&
                    Obstacles.xCurrentObstacle + Obstacles.currentObstacle.Length > 9 &&
                    !inJump ||
                    Obstacles.xCurrentObstacle > 9 &&
                    Obstacles.xCurrentObstacle < 13 &&
                    !inJump 
                )
            {
                dead = true;
            }
            return dead;
        }
    }
}



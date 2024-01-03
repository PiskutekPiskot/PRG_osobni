using System;
namespace GameTest
{
	public class movment
	{
		public movment()
		{
            int a = 0;
            int b = 0;
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                if (key.Equals(ConsoleKey.UpArrow)) a -= 1;
                if (key.Equals(ConsoleKey.DownArrow)) a += 1;
                if (key.Equals(ConsoleKey.LeftArrow)) b -= 1;
                if (key.Equals(ConsoleKey.RightArrow)) b += 1;
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("");
                }
                for (int i = 0; i < b; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("O");
            }
        }
	}
}


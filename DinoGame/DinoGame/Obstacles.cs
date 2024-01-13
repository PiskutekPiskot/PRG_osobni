using System;
namespace DinoGame
{
	
	public class Obstacles
	{
		public static bool obstacleOnScreen = false;
        public static string currentObstacle;
		public static int xCurrentObstacle;
		public static int obstacleType;
        public static List<string> obstacles = new List<string> { "/\\", "/\\/\\", "/\\/\\/\\" };
		public static string GenerateObstacle()
		{
			obstacleOnScreen = true;
            Random rnd = new Random();
            obstacleType = rnd.Next(3);
			currentObstacle = obstacles[obstacleType];
			return currentObstacle;
		}
	}
}


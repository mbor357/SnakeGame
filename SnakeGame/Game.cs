using SnakeGame.Helpers;
using SnakeGame.Models;

namespace SnakeGame
{
    public static class Game
    {
        public static void Run(GameConfig gameConfig)
        {
            while (true)
            {
                Console.Clear();
                Utilities.DrawBoundaries(gameConfig.AreaHeight, gameConfig.AreaWidth);
                Console.ReadKey();
                break;
            }
        }
    }
}

using SnakeGame.Helpers;
using SnakeGame.Models;

namespace SnakeGame
{
    public static class Game
    {
        public static void Run(GameConfig gameConfig)
        {
            Snake snake = new Snake(gameConfig.AreaWidth, gameConfig.AreaHeight);

            while (true)
            {
                Console.Clear();
                Utilities.DrawBoundaries(gameConfig.AreaHeight, gameConfig.AreaWidth);
                Utilities.DrawSnake(snake);
                Console.ReadKey();
                break;
            }
        }
    }
}
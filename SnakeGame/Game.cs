using SnakeGame.Enumes;
using SnakeGame.Helpers;
using SnakeGame.Models;

namespace SnakeGame
{
    public static class Game
    {
        public static void Run(GameConfig gameConfig)
        {
            Snake snake = new Snake(gameConfig.AreaWidth, gameConfig.AreaHeight);
            Direction direction = Direction.Left;

            while (true)
            {
                Console.Clear();
                Utilities.DrawBoundaries(gameConfig.AreaHeight, gameConfig.AreaWidth);
                Utilities.DrawSnake(snake);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    switch (info.Key)
                    {
                        case ConsoleKey.UpArrow: if (direction != Direction.Down) direction = Direction.Up; break;
                        case ConsoleKey.DownArrow: if (direction != Direction.Up) direction = Direction.Down; break;
                        case ConsoleKey.LeftArrow: if (direction != Direction.Right) direction = Direction.Left; break;
                        case ConsoleKey.RightArrow: if (direction != Direction.Left) direction = Direction.Right; break;
                    }
                }

                Utilities.MoveSnake(snake, direction);

                Thread.Sleep(100);
            }
        }
    }
}
using SnakeGame.Enumes;
using SnakeGame.Models;

namespace SnakeGame.Helpers
{
    public static class Utilities
    {
        public static void WriteOptionsSelect(List<Option> options, Option selectedOption, string title)
        {
            Console.Clear();
            Console.WriteLine(title);

            foreach (Option option in options)
            {
                if (option == selectedOption) Console.Write("> ");
                else Console.Write(" ");

                Console.WriteLine(option.Name);
            }
        }

        public static void DrawBoundaries(int arenaHeight, int arenaWidth)
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < arenaWidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("█");
                Console.SetCursorPosition(i, arenaHeight - 1);
                Console.Write("█");
            }
            for (int i = 0; i < arenaHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("██");
                Console.SetCursorPosition(arenaWidth - 1, i);
                Console.Write("██");
            }
        }

        public static void DrawSnake(Snake snake)
        {
            foreach (var segment in snake.SnakeBody)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(segment.X, segment.Y);
                Console.Write("██");
            }
            Console.ResetColor();
        }

        public static void MoveSnake(Snake snake, Direction direction)
        {
            Pixel newHeadPosition = new Pixel() 
            { 
                X = snake.SnakeBody[0].X,
                Y = snake.SnakeBody[0].Y,
            };

            switch (direction)
            {
                case Direction.Up: newHeadPosition.Y--; break;
                case Direction.Down: newHeadPosition.Y++; break;
                case Direction.Left: newHeadPosition.X = newHeadPosition.X - 2; break;
                case Direction.Right: newHeadPosition.X = newHeadPosition.X + 2; break;
            }

            snake.SnakeBody.Insert(0, newHeadPosition);
        }

        public static void DrawScores(int scores, int arenaHeight)
        {
            Console.SetCursorPosition(0, arenaHeight + 1);
            Console.Write("Punkty: " + scores);
        }

        public static Pixel DrawFood(Snake snake, int arenaHeight, int arenaWidth)
        {
            Random random = new Random();

            Pixel food = new Pixel();

            food.X = random.Next(2, arenaWidth);
            food.Y = random.Next(1, arenaHeight);

            while (snake.SnakeBody.Any(x => x == food))
            {
                food.X = random.Next(0, arenaWidth);
                food.Y = random.Next(0, arenaHeight);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(food.X, food.Y);
            Console.Write("██");

            Console.ResetColor();

            return new Pixel();
        }
    }
}
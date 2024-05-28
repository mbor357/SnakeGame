using SnakeGame.Helpers;
using SnakeGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

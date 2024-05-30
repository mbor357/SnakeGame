using SnakeGame;
using SnakeGame.Helpers;
using SnakeGame.Models;

int index = 0;
List<Option> options = new List<Option>()
{
    new Option("Start", () => Game.Run(new GameConfig())), // Start game
    new Option("Ustawienia gry", () => Console.WriteLine("\nWybrano 'Ustawienia gry'")), // Board size settings, difficulty level, snake speed
    new Option("Zakończ grę", () => Environment.Exit(0)) // Exit
};

Utilities.WriteOptionsSelect(options, options[index], "Używając strzałek wybierz opcję:\n");

ConsoleKeyInfo keyinfo;
do
{
    keyinfo = Console.ReadKey();
    if (keyinfo.Key == ConsoleKey.DownArrow && index + 1 < options.Count)
    {
        index++;
        Utilities.WriteOptionsSelect(options, options[index], "Używając strzałek wybierz opcję:\n");
    }
    if (keyinfo.Key == ConsoleKey.UpArrow && index - 1 >= 0)
    {
        index--;
        Utilities.WriteOptionsSelect(options, options[index], "Używając strzałek wybierz opcję:\n");
    }
    if (keyinfo.Key == ConsoleKey.Enter)
    {
        options[index].Selected.Invoke();
    }
} while (true);
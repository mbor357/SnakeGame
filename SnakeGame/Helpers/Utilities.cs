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
    }
}
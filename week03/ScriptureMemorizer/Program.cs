using System;

class Program
{
    static void ClearConsole()
    {
        Console.Clear();
    }

    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(ref1, "For God so loved the world that he gave his one and only Son.");

        while (true)
        {
            ClearConsole();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are now hidden. Program ending.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            Random rnd = new Random();
            scripture.HideRandomWords(rnd.Next(1, 4));
        }
    }
}

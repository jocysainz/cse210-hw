using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("==============================================");
        Console.WriteLine("        WELCOME TO GUESS MY NUMBER!!!         ");
        Console.WriteLine("==============================================");
        Console.ResetColor();
        Console.WriteLine();

        string playAgain;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess;
            int guessCount = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");
            Console.ResetColor();

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("What is your guess? ");
                Console.ResetColor();

                string input = Console.ReadLine();
                guess = int.Parse(input);
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Higher");
                    Console.ResetColor();
                }
                else if (guess > magicNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lower");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"It took you {guessCount} guess{(guessCount > 1 ? "es" : "")}.");
                    Console.ResetColor();
                }

            } while (guess != magicNumber);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Do you want to play again? (yes/no) ");
            Console.ResetColor();
            playAgain = Console.ReadLine().ToLower();
            Console.WriteLine();

        } while (playAgain == "yes");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Thanks for playing! Goodbye.");
        Console.ResetColor();
    }
}

using System;
using System.Linq;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        Start();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{prompt}");
        Console.ResetColor();
        Console.WriteLine("You have a few seconds to think...");
        Countdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();
            Console.ReadLine();
            count++;
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nYou listed {count} items! 🎉");
        Console.ResetColor();

        End();
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}

using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private string[] _encouragement =
    {
        "You're doing great! ✨",
        "Keep going! 🌟",
        "Relax and focus... 🌿",
        "Nice work! 🌸"
    };

    public ReflectionActivity()
        : base("Reflection",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
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
        Console.WriteLine("\nReflect on this while the timer runs...");

        int elapsed = 0;
        while (elapsed < _duration)
        {
            string question = _questions[rand.Next(_questions.Length)];
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + question);
            Console.ResetColor();

            Spinner(5);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(_encouragement[rand.Next(_encouragement.Length)]);
            Console.ResetColor();

            elapsed += 5;
        }

        End();
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}

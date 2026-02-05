using System;
using System.Linq;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        Start();

        int elapsed = 0;
        int breathTime = 4;

        while (elapsed < _duration)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBreathe in... 🌬");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("🌿", i)));
                Thread.Sleep(400);
            }
            Console.ResetColor();
            elapsed += breathTime;

            if (elapsed >= _duration) break;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nBreathe out... 💨");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("🌿", i)));
                Thread.Sleep(400);
            }
            Console.ResetColor();
            elapsed += breathTime;
        }

        End();
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}

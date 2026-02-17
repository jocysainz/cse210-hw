using System;

/*
CREATIVITY & EXCEEDING REQUIREMENTS:

added GoalManager class to separate logic from Program (better abstraction)
added infinite symbol [∞] for Eternal goals
checklist goals properly track incremental progress and bonus logic
*/

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            manager.DisplayScore();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.ListGoals();
                    break;

                case "3":
                    manager.RecordEvent();
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;

                case "5":
                    Console.Write("Enter filename: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;

                case "6":
                    running = false;
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Goal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                break;

            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }
}

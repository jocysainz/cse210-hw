using System;
using System.Collections.Generic;

class Program
{
    static void ClearConsole()
    {
        Console.Clear();
    }

    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("Leviticus", 19, 33, 34),
            "And if a stranger sojourn with thee in your land, ye shall not vex him. But the stranger that dwelleth with you shall be unto you as one born among you, and thou shalt love him as thyself; for ye were strangers in the land of Egypt: I am the LORD your God."
        ));

        scriptures.Add(new Scripture(
            new Reference("Matthew", 25, 35),
            "For I was hungry and you gave me food, I was thirsty and you gave me drink, I was a stranger and you welcomed me."
        ));

        scriptures.Add(new Scripture(
            new Reference("2 Nephi", 26, 33),
            "For none of these iniquities come of the Lord; for he doeth that which is good among the children of men; and he doeth nothing save it be plain unto the children of men; and he inviteth them all to come unto him and partake of his goodness; and he denieth none that come unto him, black and white, bond and free, male and female; and he remembereth the heathen; and all are alike unto God, both Jew and Gentile."
        ));

        scriptures.Add(new Scripture(
            new Reference("Doctrine and Covenants", 38, 34, 35),
            "And now, I give unto the church in these parts a commandment, that certain men among them shall be appointed… And they shall look to the poor and the needy, and administer to their relief that they shall not suffer; and send them forth to the place which I have commanded them."
        ));

        foreach (Scripture scripture in scriptures)
        {
            while (!scripture.IsCompletelyHidden())
            {
                ClearConsole();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "quit")
                    return;

                scripture.HideRandomWords(new Random().Next(1, 4));
            }
        }

        ClearConsole();
        Console.WriteLine("All scriptures have been memorized!");
    }
}

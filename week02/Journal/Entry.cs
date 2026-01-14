using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _tag;
    private int _wordCount;

    public Entry(string date, string promptText, string entryText, string tag)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _tag = tag;
        _wordCount = CalculateWordCount();
    }

    private int CalculateWordCount()
    {
        if (string.IsNullOrWhiteSpace(_entryText))
            return 0;

        return _entryText.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public void Display()
    {
        Console.WriteLine("\n----------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Tag: {_tag}");
        Console.WriteLine($"Word Count: {_wordCount}");
    }

    public void ShowReflectionFeedback()
    {
        if (_wordCount < 20)
            Console.WriteLine("Nice reflection");
        else if (_wordCount < 50)
            Console.WriteLine("You're doing great");
        else
            Console.WriteLine("🌟");
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}|{_tag}";
    }
}

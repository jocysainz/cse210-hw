using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitWords = text.Split(' ');
        foreach (var w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rnd.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{displayText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (var w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}

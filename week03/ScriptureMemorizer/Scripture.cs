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

        string[] split = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var w in split)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = rnd.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";
        foreach (var w in _words)
        {
            result += w.GetDisplayText() + " ";
        }
        return result.Trim();
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

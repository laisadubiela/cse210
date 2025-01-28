using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var _random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            var visibleWords = _words.FindAll(word => !word.IsHidden());
            if (IsCompleteHidden())
            {
                break;
            }
            int _index = _random.Next(visibleWords.Count);
            visibleWords[_index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string wordsDisplayText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return _reference.GetDisplayText() + " " + wordsDisplayText;
    }

    public bool IsCompleteHidden()
    {
        return _words.TrueForAll(word => word.IsHidden());
    }
}
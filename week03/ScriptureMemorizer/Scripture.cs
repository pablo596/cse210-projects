using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    // Returns the full scripture text with hidden words replaced
    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {wordsText}";
    }

    // Hides a given number of random visible words
    public void HideRandomWords(int count)
    {
        var random = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        int wordsToHide = Math.Min(count, visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // Checks if all words are hidden
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words { get; set; }
    private Random random = new Random(); // Initialize Random once

    public Scripture(string book, int chapter, int startVerse, string text)
        : this(new Reference(book, chapter, startVerse), text)
    {
    }

    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
        : this(new Reference(book, chapter, startVerse, endVerse), text)
    {
    }

    private Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(String.Join(" ", Words.Select(w => w.ToString()))); // Ensure spaces between words
    }

    public bool IsFullyHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        // Filter to only get words that are not hidden
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();

        // Hide words only if there are enough visible words left
        for (int i = 0; i < Math.Min(numberOfWordsToHide, visibleWords.Count); i++)
        {
            int indexToHide = random.Next(visibleWords.Count);
            visibleWords[indexToHide].Hide();
            visibleWords.RemoveAt(indexToHide); // Remove the hidden word from the list of visible words
        }
    }
}

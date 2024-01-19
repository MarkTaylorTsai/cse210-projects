using System;
using System.Collections.Generic;

public class Journal
{
    private List<JournalEntry> entries;

    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    public List<JournalEntry> GetEntries()
    {
        return entries;
    }

    public void SetEntries(List<JournalEntry> loadedEntries)
    {
        entries = loadedEntries;
    }

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        foreach (JournalEntry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
}
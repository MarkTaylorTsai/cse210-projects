using System;
using System.IO;
using System.Collections.Generic;

public class FileManager
{
    public void SaveJournal(string filename, List<JournalEntry> entries)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Promt}|{entry.Response}");
            }
        }
    }

    public List<JournalEntry> LoadJournal(string filename)
    {
        List<JournalEntry> entries = new List<JournalEntry>();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                entries.Add(new JournalEntry(parts[1], parts[2], parts[0]));
            }
        }
        return entries;
    }
}

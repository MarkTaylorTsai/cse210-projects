using System;

public class JournalEntry
{
    public string Promt { get; set; }
    public string Date { get; set; }
    public string Response { get; set; }

    public JournalEntry(string promt, string date, string response)
    {
        Promt = promt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date} - {Promt}: {Response}";
    }
}
using System;

class Program
{
    static Journal journal = new Journal();
    static FileManager fileManager = new FileManager();
    static PromptManager promptManager = new PromptManager();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to the journal program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            switch (Console.ReadLine())
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    LoadJournal();
                    break;
                case "4":
                    SaveJournal();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid number, please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        string prompt = promptManager.GetRandomPromt();
        Console.WriteLine($"Today's prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        journal.AddEntry(new JournalEntry(prompt, response, date));
    }

    static void DisplayJournal()
    {
        Console.WriteLine("Journal Entries: ");
        journal.DisplayAllEntries();
    }

    static void SaveJournal()
    {
        Console.WriteLine("Enter filename to save: ");
        string filename = Console.ReadLine();
        fileManager.SaveJournal(filename, journal.GetEntries());
        Console.WriteLine("Journal saved successfully.");
    }

    static void LoadJournal()
    {
        Console.WriteLine("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.SetEntries(fileManager.LoadJournal(filename));
    }
}
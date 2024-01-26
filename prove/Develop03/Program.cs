using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.");

        while (true)
        {
            scripture.Display();

            if (scripture.IsFullyHidden())
            {
                Console.WriteLine("All words are hidden. Memorization complete!");
                break;
            }

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }
    }

}
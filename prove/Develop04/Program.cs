using System;

class Program
{
    static void Main(string[] args)
    {
        Activity selectedActivity = null;

        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("Choose an activity to perform:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    selectedActivity = new BreathingActivity();
                    break;
                case "2":
                    selectedActivity = new ReflectionActivity();
                    break;
                case "3":
                    selectedActivity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Exiting program. Thank you for participating in the mindfulness exercises!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    continue;
            }

            selectedActivity?.ExecuteActivity();
        }

    }
}
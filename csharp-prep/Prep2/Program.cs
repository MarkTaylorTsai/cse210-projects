using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?(do not include the sign %) ");
        string grade_string = Console.ReadLine();
        int grade = int.Parse(grade_string);

        if (grade >= 90)
        {
            Console.WriteLine($"Your grade is A!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"Your grade is B!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"Your grade is C!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"Your grade is D!");
        }
        else
        {
            Console.WriteLine($"Your grade is F!");
        }

        if (!(grade < 60))
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Gotta try harder next time kid!");
        }
    }
}
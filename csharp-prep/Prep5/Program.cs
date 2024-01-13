using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;

    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int number)
    {
        int sqr = number * number;
        return sqr;
    }
    static void DisplayResult()
    {
        DisplayWelcome();
        string name = PromptUserName();
        int sqr = SquareNumber(PromptUserNumber());
        Console.WriteLine($"Brother {name}, the square of your number is {sqr}");
    }
}


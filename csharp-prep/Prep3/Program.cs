using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Random numGenerator = new Random();
        int number = numGenerator.Next(1, 99);
        int answerInt = 0;
        while (!(answerInt == number))
        {
            Console.Write("What is the magic number? ");
            string answer = Console.ReadLine();
            answerInt = int.Parse(answer);
            if (number > answerInt)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}
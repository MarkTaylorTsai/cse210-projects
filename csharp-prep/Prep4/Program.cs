using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }
        int sum = 0;
        float ave = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            ave = sum / numbers.Count;
        };
        int max = 0;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {max}");

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction cool = new Fraction();
        Fraction fra1 = new Fraction(5);
        Fraction fra2 = new Fraction(3, 4);
        Fraction fra3 = new Fraction(1, 3);

        Console.WriteLine(cool.GetFractionString());
        Console.WriteLine(cool.GetDecimalValue());
        Console.WriteLine(fra1.GetFractionString());
        Console.WriteLine(fra1.GetDecimalValue());
        Console.WriteLine(fra2.GetFractionString());
        Console.WriteLine(fra2.GetDecimalValue());
        Console.WriteLine(fra3.GetFractionString());
        Console.WriteLine(fra3.GetDecimalValue());
    }


}
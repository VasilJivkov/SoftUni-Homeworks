using System;

class Calculations
{
    static void Main()
    {
        Console.Write("Enter n: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());

        double factorial = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            result += factorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:0.00000}", result);
    }
}


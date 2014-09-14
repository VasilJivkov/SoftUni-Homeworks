using System;

class SumOfNNumbers
{
    static void Main()
    {
        double sum = 0;
        double n = double.Parse(Console.ReadLine());
        for (double i = 1; i <= n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum = sum + number;

        }
        Console.WriteLine(sum);
    }
}

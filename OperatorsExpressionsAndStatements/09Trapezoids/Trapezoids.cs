using System;

class Trapezoids
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal h = decimal.Parse(Console.ReadLine());

        decimal Area = ((a + b) / 2) * h;
        Console.WriteLine(Area);
    }
}

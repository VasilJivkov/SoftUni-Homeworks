using System;

class PiontInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (((x * x) + (y * y)) <= 2 * 2);
        Console.WriteLine(isInCircle);
    }
}

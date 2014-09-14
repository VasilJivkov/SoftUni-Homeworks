using System;

class CirclePerAndArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double Area = Math.PI * r * r;
        Console.WriteLine("Perismeter equals : " + perimeter);
        Console.WriteLine("Area equals : " + Area);
    }
}

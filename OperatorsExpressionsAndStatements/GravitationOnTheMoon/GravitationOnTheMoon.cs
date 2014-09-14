using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double WeightOnEarth = double.Parse(Console.ReadLine());
        double WeightOnMoon = WeightOnEarth * 0.17;
        Console.WriteLine(WeightOnMoon);
    }
}


using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double D = ((b * b) - (4 * a * c));
        if (D > 0)
        {
            double X1 = (-b - Math.Sqrt(D)) / (2 * a);
            double X2 = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine(" x1= "+ X1 +"; "+"x2= "+ X2);
        }
        if (D == 0)
        {
            double X = (-b) / (2 * a);
            Console.WriteLine("X1=X2="+X);
        }
        if (D < 0)
        {
            Console.WriteLine("No real Roots");
        }
    }
}

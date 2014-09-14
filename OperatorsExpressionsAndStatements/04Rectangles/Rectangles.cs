using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = width * 2 + height * 2;
        double area = width * height;
        Console.WriteLine("The perimeter is : " + perimeter );
        Console.WriteLine("The Area is : " + area );
    }
}

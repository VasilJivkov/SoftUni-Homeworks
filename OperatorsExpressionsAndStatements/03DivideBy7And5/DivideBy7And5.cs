using System;

class DivideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isDividable = number % 5 == 0 && number % 7 == 0;
        Console.WriteLine(isDividable);
    }
}

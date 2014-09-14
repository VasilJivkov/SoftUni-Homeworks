using System;

class ThirdDigit7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isSeven = (number / 100) % 10 == 7;
        Console.WriteLine(isSeven);
    }
}

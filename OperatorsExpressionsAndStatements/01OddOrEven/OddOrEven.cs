using System;

class OddOrEven
{
    static void Main()
    {
        int number =int.Parse(Console.ReadLine());
        bool isEven = number%2  == 0;
        Console.WriteLine(isEven);
    }
}

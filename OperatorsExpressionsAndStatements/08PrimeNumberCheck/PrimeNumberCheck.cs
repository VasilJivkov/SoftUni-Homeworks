using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number >= 1)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

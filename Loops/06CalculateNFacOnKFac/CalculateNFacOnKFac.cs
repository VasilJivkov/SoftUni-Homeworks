﻿using System;

class CalculateNFacOnKFac
{
    static void Main()
    {
        Console.Write("Enter n: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        double k = double.Parse(Console.ReadLine());
        bool inRange = n < 100 && k > 1 && n > k;

        if (inRange)
        {
            double nFactorial = 1;
            double kFactorial = 1;
            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;

                if (i <= k)
                {
                    kFactorial *= i;
                }
            }

            result = nFactorial / kFactorial;
            Console.WriteLine("{0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input. Correct input --> 1 < k < n < 100");
        }
    }
}

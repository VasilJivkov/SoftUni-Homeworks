﻿using System;

class CalculateChance
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        bool inRange = n < 100 && k > 1 && n > k;
 
        if (inRange)
        {
            double nFactorial = 1;
            double kFactorial = 1;
            double differenceFactorial = 1;
            double result = 0;
 
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
 
                if (i <= k)
                {
                    kFactorial *= i;
                }
            }
            for (int i = 1; i <= n - k; i++)
            {
                differenceFactorial *= i;
            }
 
            result = nFactorial / (kFactorial * differenceFactorial);
            Console.WriteLine("{0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input. Correct input --> 1 < k < n < 100");
        }
    }
}
}

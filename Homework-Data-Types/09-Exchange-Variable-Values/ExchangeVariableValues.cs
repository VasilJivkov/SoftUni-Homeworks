using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = b;
        b = c;
        Console.WriteLine("Exchanged!");
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}


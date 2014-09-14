using System;

class CheckBitAtGivenPostion
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        bool isOne = ((1 << p) & number) > 0 ;
        Console.WriteLine(isOne);
    }
}

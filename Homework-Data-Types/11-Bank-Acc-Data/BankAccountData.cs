using System;

class BankAccountData
{
    static void Main()
    {
        string FirstName = "Ivan";
        string MiddleName = "Ivanov";
        string LastName = "Ivanov";
        decimal balance = 2000.26264m;
        string BankName = "DSK";
        string IBAN = "BG47212110090000000235698741";
        int LastDigits = 805 ;

        Console.WriteLine(FirstName);
        Console.WriteLine(MiddleName);
        Console.WriteLine(LastName);
        Console.WriteLine(balance);
        Console.WriteLine(BankName);
        Console.WriteLine(IBAN);
        Console.WriteLine(LastDigits);
    }
}

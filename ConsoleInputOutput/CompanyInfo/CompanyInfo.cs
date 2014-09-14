using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company adress: ");
        string companyAdress = Console.ReadLine();

        Console.Write("Company number:  ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Company Fax number: ");
        string faxNumber = Console.ReadLine();
        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }
        Console.Write("Company Web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager First Name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager Last Name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Manager Phone Number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("{0}\nAdress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6}(age: {7} , tel. {8}",companyName,companyAdress,phoneNumber,faxNumber,webSite,managerFirstName,managerLastName,age,managerPhoneNumber );
    }
}

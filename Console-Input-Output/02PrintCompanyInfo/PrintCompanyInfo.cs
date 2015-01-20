using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Insert company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Insert company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Insert company phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Insert company fax number:");
        string faxNumber = Console.ReadLine();
        Console.Write("Insert company web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Insert manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Insert manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Insert manager age: ");
        string age = Console.ReadLine();
        Console.Write("Insert manager phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager:{5} {6} (age:{7}, tel. {8})",companyName,companyAddress,phoneNumber,faxNumber,webSite,firstName,lastName,age,managerPhone);
        
    }
}

using System;
class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Holder First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Holder Middle Name:");
        string middleName = Console.ReadLine();

        Console.WriteLine("Holder Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Amount of money:");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Bank Name:");
        string bankName = Console.ReadLine();

        Console.WriteLine("IBAN:");
        string ibanNumber = Console.ReadLine();

        Console.WriteLine("First credit card number:");
        string firstCreditCard = Console.ReadLine();
        ulong firstCard;
        while (!ulong.TryParse(firstCreditCard, out firstCard))
        {
            Console.WriteLine("Invalid input. Enter first credit card number:");
            firstCreditCard = Console.ReadLine();
        }

        Console.WriteLine("Second credit card number:");
        string secondCreditCard = Console.ReadLine();
        ulong secondCard;
        while (!ulong.TryParse(secondCreditCard, out secondCard))
        {
            Console.WriteLine("Invalid input. Enter second credit card number:");
            secondCreditCard = Console.ReadLine();
        }

        Console.WriteLine("Third credit card number:");
        string thirdCreditCard = Console.ReadLine();
        ulong thirdCard;
        while (!ulong.TryParse(thirdCreditCard, out thirdCard))
        {
            Console.WriteLine("Invalid input. Enter third credit card number:");
            thirdCreditCard = Console.ReadLine();
        }

        Console.WriteLine("First Name:" + firstName);
        Console.WriteLine("Middle Name:" + middleName);
        Console.WriteLine("Last Name:" + lastName);
        Console.WriteLine("Available amount of money:" + amount);
        Console.WriteLine("IBAN:" + ibanNumber);
        Console.WriteLine("First credit card number:" + firstCard);
        Console.WriteLine("Second credit card number:" + secondCard);
        Console.WriteLine("Third credit card number:" + thirdCard);

    }
}

using System;

public class TicketPriceCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        int age;
        double discount = 7.00;
        double ticketPrice = 10.00;

        // Parsing user input
        if (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
            return;
        }

        double finalPrice = ticketPrice; // Assume regular price by default

        // Checking age for discounts
        if (age <= 12)
        {
            finalPrice -= discount; // Apply child discount
            Console.WriteLine("A Child pays: GHC" + finalPrice + " cedis.");
        }
        else if (age >= 65)
        {
            finalPrice -= discount; // Apply senior citizen discount
            Console.WriteLine("A Senior Citizen pays: GHC " + finalPrice + " cedis.");
        }
        else
        {
            Console.WriteLine("A Regular Customer pays: GHC " + ticketPrice + " cedis.");
        }
    }
}

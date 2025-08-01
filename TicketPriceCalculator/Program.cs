using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 0)
                {
                    Console.WriteLine("Invalid age. Age cannot be negative.");
                }
                else if (age <= 12 || age >= 65)
                {
                    Console.WriteLine("Ticket Price: GHC 7");
                }
                else
                {
                    Console.WriteLine("Ticket Price: GHC 10");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
            }

            Console.Write("Do you want to check another ticket price? (y/n): ");
            repeat = Console.ReadLine().Trim().ToLower() == "y";
        }
    }
}

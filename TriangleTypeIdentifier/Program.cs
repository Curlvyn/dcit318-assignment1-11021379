using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            try
            {
                Console.Write("Enter side 1: ");
                double side1 = double.Parse(Console.ReadLine());

                Console.Write("Enter side 2: ");
                double side2 = double.Parse(Console.ReadLine());

                Console.Write("Enter side 3: ");
                double side3 = double.Parse(Console.ReadLine());

                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("Sides must be positive numbers.");
                }
                else if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Triangle Type: Equilateral");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("Triangle Type: Isosceles");
                }
                else
                {
                    Console.WriteLine("Triangle Type: Scalene");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for all sides.");
            }

            Console.Write("Do you want to classify another triangle? (y/n): ");
            repeat = Console.ReadLine().Trim().ToLower() == "y";
        }
    }
}

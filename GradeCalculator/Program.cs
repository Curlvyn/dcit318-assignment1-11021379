using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            try
            {
                Console.Write("Enter your numerical grade (0.0 - 100.0): ");
                double grade = double.Parse(Console.ReadLine());

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
                }
                else if (grade >= 90)
                    Console.WriteLine("Letter Grade: A");
                else if (grade >= 80)
                    Console.WriteLine("Letter Grade: B");
                else if (grade >= 70)
                    Console.WriteLine("Letter Grade: C");
                else if (grade >= 60)
                    Console.WriteLine("Letter Grade: D");
                else
                    Console.WriteLine("Letter Grade: F");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number (e.g., 85.5).");
            }

            Console.Write("Do you want to calculate another grade? (y/n): ");
            repeat = Console.ReadLine().Trim().ToLower() == "y";
        }
    }
}

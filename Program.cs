
// This simple C# console application asks the user for their name and age,
// then lets them enter an expected age they want to reach.
// It calculates the year when they will reach that age.
// It demonstrates basic input/output, validation, and use of DateTime.

using System;

namespace YearTargetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome! Let's find out what year you will reach your desired age!");

            // Ask for name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // Ask for current age with validation
            Console.Write("Enter your current age: ");
            int currentAge;
            while (!int.TryParse(Console.ReadLine(), out currentAge) || currentAge <= 0)
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            // Ask for expected target age with validation
            Console.Write("Enter the age you want to know about (e.g., 65, 80, 100): ");
            int targetAge;
            while (!int.TryParse(Console.ReadLine(), out targetAge) || targetAge <= currentAge)
            {
                Console.Write("Invalid input. Please enter an age greater than your current age: ");
            }

            // Calculate year
            int currentYear = DateTime.Now.Year;
            int yearToReachTarget = currentYear + (targetAge - currentAge);

            // Display result
            Console.WriteLine($"\nHello {name}, you are {currentAge} years old.");
            Console.WriteLine($"You will turn {targetAge} years old in the year {yearToReachTarget}.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

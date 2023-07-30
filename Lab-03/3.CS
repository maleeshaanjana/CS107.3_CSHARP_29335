using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sum of Digits Calculator!");

            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            if (long.TryParse(userInput, out long number))
            {
                long sumOfDigits = 0;

                while (number > 0)
                {
                    long digit = number % 10;
                    sumOfDigits += digit;
                    number /= 10;
                }

                Console.WriteLine($"Sum of the digits: {sumOfDigits}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

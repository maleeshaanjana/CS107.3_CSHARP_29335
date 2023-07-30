using System;

namespace EvenOrOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Even or Odd Checker!");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Please enter number {i}: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int number))
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is an even number.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is an odd number.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

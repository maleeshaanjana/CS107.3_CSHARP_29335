using System;

namespace SummationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Summation Console App!");

            Console.Write("Please enter the first number: ");
            string firstInput = Console.ReadLine();

            Console.Write("Please enter the second number: ");
            string secondInput = Console.ReadLine();

            if (double.TryParse(firstInput, out double firstNumber) && double.TryParse(secondInput, out double secondNumber))
            {
                double sum = firstNumber + secondNumber;

                Console.WriteLine($"The summation of {firstNumber} and {secondNumber} is: {sum}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

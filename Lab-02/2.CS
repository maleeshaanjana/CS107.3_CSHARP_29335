using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Calculator!");

            Console.Write("Please enter the first number: ");
            string firstInput = Console.ReadLine();

            Console.Write("Please enter the second number: ");
            string secondInput = Console.ReadLine();

            if (double.TryParse(firstInput, out double firstNumber) && double.TryParse(secondInput, out double secondNumber))
            {
                double sum = firstNumber + secondNumber;
                Console.WriteLine($"Sum: {sum}");

                double subtraction = firstNumber - secondNumber;
                Console.WriteLine($"Subtraction: {subtraction}");

                double multiplication = firstNumber * secondNumber;
                Console.WriteLine($"Multiplication: {multiplication}");

                if (secondNumber != 0)
                {
                    double division = firstNumber / secondNumber;
                    Console.WriteLine($"Division: {division}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
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

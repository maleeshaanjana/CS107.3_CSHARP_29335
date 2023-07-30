using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Arithmetic Operations Calculator!");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice (1/2/3/4): ");
            string choiceInput = Console.ReadLine();

            if (int.TryParse(choiceInput, out int choice))
            {
                if (choice >= 1 && choice <= 4)
                {
                    Console.Write("Please enter the first number: ");
                    string num1Input = Console.ReadLine();

                    Console.Write("Please enter the second number: ");
                    string num2Input = Console.ReadLine();

                    if (double.TryParse(num1Input, out double num1) && double.TryParse(num2Input, out double num2))
                    {
                        CalculateValues calculator = new CalculateValues();

                        double result = 0;
                        switch (choice)
                        {
                            case 1: 
                                result = calculator.Addition(num1, num2);
                                break;
                            case 2: 
                                result = calculator.Subtraction(num1, num2);
                                break;
                            case 3: 
                                result = calculator.Multiplication(num1, num2);
                                break;
                            case 4: 
                                result = calculator.Division(num1, num2);
                                break;
                        }

                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid input. Please enter valid numbers for calculations.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid choice. Please enter a valid choice (1/2/3/4).");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid choice (1/2/3/4).");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    class CalculateValues
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
        }
    }
}

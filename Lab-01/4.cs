using System;

namespace SalaryAfterTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Salary After Tax Calculator!");

            Console.Write("Please enter the employee's salary: ");
            string salaryInput = Console.ReadLine();
t
            Console.Write("Please enter the tax rate (in decimal format, e.g., 0.20 for 20%): ");
            string taxRateInput = Console.ReadLine();

            if (double.TryParse(salaryInput, out double salary) && double.TryParse(taxRateInput, out double taxRate))
            {
                if (taxRate >= 0 && taxRate <= 1)
                {
                    double salaryAfterTax = salary * (1 - taxRate);

                    Console.WriteLine($"Salary after tax deduction: {salaryAfterTax:C2}");
                }
                else
                {
                    Console.WriteLine("Error: The tax rate should be between 0 and 1 (inclusive).");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers for salary and tax rate.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

using System;

namespace CircleAreaAndCircumferenceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Area and Circumference Calculator!");

            Console.Write("Please enter the radius of the circle: ");
            string radiusInput = Console.ReadLine();

            if (double.TryParse(radiusInput, out double radius))
            {
                if (radius >= 0)
                {
                    double area = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"Area of the circle: {area:F2}");

                    double circumference = 2 * Math.PI * radius;
                    Console.WriteLine($"Circumference of the circle: {circumference:F2}");
                }
                else
                {
                    Console.WriteLine("Error: The radius cannot be negative.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number for the radius.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

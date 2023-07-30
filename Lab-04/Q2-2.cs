using System;

namespace CircleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Properties Calculator!");

            Console.Write("Please enter the radius of the circle: ");
            string radiusInput = Console.ReadLine();

            if (double.TryParse(radiusInput, out double radius))
            {
                FindValues calculator = new FindValues();

                double area = calculator.FindArea(radius);

                double circumference = calculator.FindCircumference(radius);

                Console.WriteLine($"Area of the circle: {area:F2}");
                Console.WriteLine($"Circumference of the circle: {circumference:F2}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number for the radius.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
}

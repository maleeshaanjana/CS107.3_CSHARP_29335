using System;

namespace KilometerToMeterConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Kilometer to Meter Converter!");

            Console.Write("Please enter the distance in kilometers: ");
            string kmInput = Console.ReadLine();

            if (double.TryParse(kmInput, out double kilometers))
            {
                ConvertValues converter = new ConvertValues();

                converter.KilometerToMeter(kilometers);
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number for kilometers.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    class ConvertValues
    {
        public void KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
        }
    }
}

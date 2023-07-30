using System;

namespace NameAndBatchConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Name and Batch Console App!");
            
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Please enter your batch: ");
            string batch = Console.ReadLine();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Batch: {batch}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

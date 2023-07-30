using System;

namespace ArrayInputWithZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                SeparateArray separateArray = new SeparateArray();

                int[] array = separateArray.TakeUserInputs(size);

                Console.WriteLine("Values inside the array:");
                foreach (int value in array)
                {
                    Console.Write($"{value} ");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid positive integer for the array size.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    class SeparateArray
    {
        public int[] TakeUserInputs(int size)
        {
            int[] array = new int[size * 2];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i * 2] = value;
                    array[i * 2 + 1] = 0;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    return new int[0]; 
                }
            }
            return array;
        }
    }
}

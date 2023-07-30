using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the arrays:");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                int[] array1 = new int[size];
                int[] array2 = new int[size];

                Console.WriteLine("Enter values for Array 1:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter value {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        array1[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                        return;
                    }
                }

                Console.WriteLine("Enter values for Array 2:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter value {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        array2[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                        return;
                    }
                }

                int scalarSum = CalculateScalarSum(array1, array2);
                Console.WriteLine($"Scalar Sum: {scalarSum}");

                int[] vectorSum = CalculateVectorSum(array1, array2);
                Console.WriteLine("Vector Sum:");
                DisplayArray(vectorSum);

                int[] vectorProduct = CalculateVectorProduct(array1, array2);
                Console.WriteLine("Vector Product:");
                DisplayArray(vectorProduct);

                int scalarProduct = CalculateScalarProduct(array1, array2);
                Console.WriteLine($"Scalar Product: {scalarProduct}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid positive integer for the array size.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static int CalculateScalarSum(int[] arr1, int[] arr2)
        {
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i] + arr2[i];
            }
            return sum;
        }

        static int[] CalculateVectorSum(int[] arr1, int[] arr2)
        {
            int[] sumArray = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                sumArray[i] = arr1[i] + arr2[i];
            }
            return sumArray;
        }

        static int[] CalculateVectorProduct(int[] arr1, int[] arr2)
        {
            int[] productArray = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                productArray[i] = arr1[i] * arr2[i];
            }
            return productArray;
        }

        static int CalculateScalarProduct(int[] arr1, int[] arr2)
        {
            int product = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                product += arr1[i] * arr2[i];
            }
            return product;
        }

        static void DisplayArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}

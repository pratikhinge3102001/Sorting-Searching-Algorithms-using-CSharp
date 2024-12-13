using System;

namespace Hackerrank_C__solutions
{
    internal class LinearSearch
    {
        public static void Main12(string[] args)
        {
            Console.WriteLine("Linear Search Algorithm");
            Console.WriteLine("---------------------");

            // Input Validation and Array Initialization
            int size = GetPositiveIntegerInput("Enter number of elements: ");
            int[] array = GetIntegerArrayInput(size, "Enter elements in the array: ");

            // Display the original array
            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Get the element to search for
            int x = GetPositiveIntegerInput("Enter the element to search for: ");

            // Perform linear search
            int linearSearchIndex = LinearSearchAlgorithm(array, x);
            if (linearSearchIndex != -1)
            {
                Console.WriteLine("Element found at index " + linearSearchIndex + " using linear search.");
            }
            else
            {
                Console.WriteLine("Element not found using linear search.");
            }
        }

        #region Input/Output Helpers

        static int GetPositiveIntegerInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                {
                    return value;
                }
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        static int[] GetIntegerArrayInput(int size, string prompt)
        {
            int[] array = new int[size];
            Console.WriteLine(prompt);
            for (int i = 0; i < size; i++)
            {
                while (true)
                {
                    Console.Write($"Element {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out array[i]))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }

        #endregion

        #region Search Algorithms

        // Linear Search
        static int LinearSearchAlgorithm(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }

    #endregion
}
using System;

namespace Hackerrank_C__solutions
{
    internal class SelectionSort
    {
        public static void Main8(string[] args)
        {
            Console.WriteLine("Selection Sort Algorithm");
            Console.WriteLine("---------------------");

            // Input Validation and Array Initialization
            int size = GetPositiveIntegerInput("Enter number of elements: ");
            int[] array = GetIntegerArrayInput(size, "Enter elements in the array: ");

            // Display the original array
            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Sort the array using the Selection Sort algorithm
            SelectionSortAlgorithm(array);

            // Display the sorted array
            Console.WriteLine("Sorted Array:");
            PrintArray(array);

            // Reverse the array for descending order
            ReverseArray(array);

            // Display the sorted array in descending order
            Console.WriteLine("Sorted Array (Descending):");
            PrintArray(array);
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

        static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }


        #endregion

        #region Selection Sort Algorithm

        static void SelectionSortAlgorithm(int[] array)
        {
            int n = array.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;

                // Swap the found minimum element with the first element
                (array[minIndex], array[i]) = (array[i], array[minIndex]);
            }
        }

        #endregion
    }
}
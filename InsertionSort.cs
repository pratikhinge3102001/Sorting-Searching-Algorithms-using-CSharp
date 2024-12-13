using System;

namespace Hackerrank_C__solutions 
{
    internal class InsertionSort
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort Algorithm");
            Console.WriteLine("---------------------");

            // Input Validation and Array Initialization
            int size = GetPositiveIntegerInput("Enter number of elements: ");
            int[] array = GetIntegerArrayInput(size, "Enter elements in the array: ");

            // Display the original array
            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Sort the array using Insertion Sort
            InsertionSortAlgorithm(array);

            // Display the sorted array
            Console.WriteLine("Sorted Array:");
            PrintArray(array);

            // Reverse the array for descending order
            ReverseArray(array);
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

        #region Insertion Sort Algorithm

        static void InsertionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        #endregion
    }
}

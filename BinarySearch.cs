using System;

namespace Hackerrank_C__solutions
{
    internal class BinarySearch
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Binary Search with Bubble Sort");
            Console.WriteLine("---------------------");

            // Input Validation and Array Initialization
            int size = GetPositiveIntegerInput("Enter number of elements: ");
            int[] array = GetIntegerArrayInput(size, "Enter elements in the array: ");

            // Display the original array
            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Sort the array using Bubble Sort
            BubbleSort(array);

            // Display the sorted array
            Console.WriteLine("Sorted Array:");
            PrintArray(array);

            // Get the element to search for
            int x = GetPositiveIntegerInput("Enter the element to search for: ");

            // Perform binary search
            int binarySearchIndex = BinarySearchAlgorithm(array, 0, size - 1, x);
            if (binarySearchIndex != -1)
            {
                Console.WriteLine("Element found at index " + binarySearchIndex + " using binary search.");
            }
            else
            {
                Console.WriteLine("Element not found using binary search.");
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

        #region Sorting and Searching Algorithms

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static int BinarySearchAlgorithm(int[] arr, int left, int right, int x)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                // If the element is present at the middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then it can only be in left subarray
                if (arr[mid] > x)
                    return BinarySearchAlgorithm(arr, left, mid - 1, x);

                // Else the element can only be present in right subarray
                return BinarySearchAlgorithm(arr, mid + 1, right, x);
            }

            // We reach here when element is not present in array
            return -1;
        }

        #endregion
    }
}
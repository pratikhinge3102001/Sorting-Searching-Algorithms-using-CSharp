
using System;
namespace Hackerrank_C__solutions

{
    internal class HeapSort
    {
        public static void Main9(string[] args)
        {
            Console.WriteLine("Heap Sort Algorithm");
            Console.WriteLine("---------------------");

            // Input Validation and Array Initialization
            int size = GetPositiveIntegerInput("Enter number of elements: ");
            int[] array = GetIntegerArrayInput(size, "Enter elements in the array: ");

            // Display the original array
            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Sort the array using Heap Sort
            HeapSortAlgorithm(array);

            // Display the sorted array
            Console.WriteLine("Sorted Array Ascending:");
            PrintArray(array);


            // Reverse the array for descending order
            ReverseArray(array);
            Console.WriteLine("Sorted Array Descending:");
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

        // Reverses the order of elements in an array
        static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        #endregion

        #region Heap Sort Algorithm

        static void HeapSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // heapify root element
                Heapify(arr, i, 0);
            }
        }

        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left child
            int r = 2 * i + 2; // right child

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                // Swap
                (arr[i], arr[largest]) = (arr[largest], arr[i]);

                // Recursively heapify the affected sub-tree
                Heapify(arr, n, largest);
            }
        }

        #endregion
    }
}
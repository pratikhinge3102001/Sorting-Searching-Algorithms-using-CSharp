using System;

namespace Hackerrank_C__solutions
{
    internal class QuickSort
    {
        // Main Entry Point: This is where the program starts execution
        public static void Main6(string[] args)
        {
            Console.WriteLine("Quick Sort Algorithm");
            Console.WriteLine("---------------------");

            // Input: Get array size and elements from the user
            int size = GetPositiveIntegerInput("Enter number of elements: ");
            int[] array = GetIntegerArrayInput(size, "Enter elements in the array: ");

            // Display the original array
            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Sort the array using the QuickSort algorithm
            QuickSortAlgorithm(array, 0, size - 1);

            // Display the sorted array in ascending order
            Console.WriteLine("Sorted Array (Ascending):");
            PrintArray(array);

            // Reverse the array for descending order
            ReverseArray(array);

            // Display the sorted array in descending order
            Console.WriteLine("Sorted Array (Descending):");
            PrintArray(array);
        }

        #region Input/Output Helpers

        // Gets a positive integer input from the user
        static int GetPositiveIntegerInput(string prompt)
        {
            // Continuously prompt the user until a valid input is received
            while (true)
            {
                // Display the prompt to the user
                Console.Write(prompt);

                // Try to parse the user's input as an integer
                if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                {
                    // If the input is a valid positive integer, return it
                    return value;
                }

                // If the input is invalid, display an error message and prompt the user again
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        // Gets an integer array of the specified size from the user
        static int[] GetIntegerArrayInput(int size, string prompt)
        {
            // Create an integer array of the specified size
            int[] array = new int[size];

            // Display the prompt to the user
            Console.WriteLine(prompt);

            // Iterate through each element of the array
            for (int i = 0; i < size; i++)
            {
                // Continuously prompt the user for input until a valid integer is received
                while (true)
                {
                    // Prompt the user for the current element
                    Console.Write($"Element {i + 1}: ");

                    // Try to parse the user's input as an integer
                    if (int.TryParse(Console.ReadLine(), out array[i]))
                    {
                        // If the input is valid, break out of the loop
                        break;
                    }

                    // If the input is invalid, display an error message and prompt the user again
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }

            // Return the populated integer array
            return array;
        }
        // Prints the elements of an integer array
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

        // QuickSort Algorithm: Recursively sorts the array using the divide-and-conquer approach
        static void QuickSortAlgorithm(int[] array, int start, int end)
        {
            // Base case: If the subarray has 1 or 0 elements, it's already sorted
            if (start < end)
            {
                // Partition: Rearrange the array around a pivot element
                int pivotIndex = Partition(array, start, end);

                // Recursive calls: Sort the subarrays on either side of the pivot
                QuickSortAlgorithm(array, start, pivotIndex - 1); // Sort left subarray
                QuickSortAlgorithm(array, pivotIndex + 1, end); // Sort right subarray
            }
        }

        // Partition: Rearranges the array around a pivot element
        static int Partition(int[] array, int start, int end)
        {
            // Choose the first element as the pivot
            int pivot = array[start];

            // Partition loop: Move elements smaller than the pivot to the left and larger to the right
            while (start <= end)
            {
                // Move start pointer to the right until an element greater than or equal to the pivot is found
                while (start <= end && array[start] < pivot)
                {
                    start++;
                }

                // Move end pointer to the left until an element less than or equal to the pivot is found
                while (start <= end && array[end] > pivot)
                {
                    end--;
                }

                // If the pointers haven't crossed, swap the elements
                if (start <= end)
                {
                    Swap(array, start, end);
                    start++;
                    end--;
                }
            }

            // Return the final position of the pivot
            return end;
        }

        // Swaps two elements in the array
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
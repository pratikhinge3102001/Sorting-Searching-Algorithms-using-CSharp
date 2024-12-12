using System;

namespace Hackerrank_C__solutions
{
    internal class BubbleSort
    {
        // Main Entry Point: This is where the program starts execution
        public static void Main7(string[] args)
        {
            Console.WriteLine("Bubble Sort Algorithm");
            Console.WriteLine("---------------------");

            // Input: Get array size and elements from the user
            int size = GetPositiveIntegerInput("Enter number of elements: ");
            int[] array = GetIntegerArrayInput(size, "Enter elements in the array: ");

            // Display the original array
            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Sort the array using the Bubble Sort algorithm
            BubbleSortAlgorithm(array);

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

        #region Bubble Sort Algorithm

        // Bubble Sort: Repeatedly iterates through the list, compares adjacent elements, and swaps them if they are in the wrong order
        static void BubbleSortAlgorithm(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Flag to optimize the algorithm by breaking early if no swaps occur in a pass
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap adjacent elements
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        swapped = true;
                    }
                }
                // If no swaps occurred in this pass, the array is already sorted
                if (!swapped)
                    break;
            }
        }

        #endregion
    }
}
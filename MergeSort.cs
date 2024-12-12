using System;

namespace Hackerrank_C__solutions
{
    internal class MergeSort
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort Algorithm");
            Console.WriteLine("---------------------");

            // Input Validation and Array Initialization
            int size = GetPositiveIntegerInput("Enter number of elements: ");
            int[] array = GetIntegerArrayInput(size, "Enter elements in the array: ");

            // Display the original array
            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Sort the array using Merge Sort
            MergeSortAlgorithm(array, 0, size - 1);

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

        // Reverses the order of elements in an array
        static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        #endregion

        #region Merge Sort Algorithm

        static void MergeSortAlgorithm(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSortAlgorithm(arr, left, mid);
                MergeSortAlgorithm(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] LeftArray = new int[n1];
            int[] RightArray = new int[n2];

            Array.Copy(arr, left, LeftArray, 0, n1);
            Array.Copy(arr, mid + 1, RightArray, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (LeftArray[i] <= RightArray[j])
                {
                    arr[k] = LeftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = RightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = LeftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = RightArray[j];
                j++;
                k++;
            }
        }

        #endregion
    }
}

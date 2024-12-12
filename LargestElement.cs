using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_C__solutions
{
    internal class LargestElement
    {
        static int FindLargestElement(int[] arr)
        {
            

            int max = arr[0];

            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;


        }

        public static void Main(string[] args)
        {
            Console.WriteLine("enter no. of elements");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                Console.WriteLine("array must contain at least one element");

                return;
            }

            int[] array = new int[size];

            Console.WriteLine("Enter elements in the array");

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            int max = FindLargestElement(array);

            Console.WriteLine("Maximum element is  " + max);
        }
    }
}

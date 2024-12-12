

/*
 * Given an array of integers, find the sum of its elements.

For example, if the array , , so return .

Function Description

Complete the simpleArraySum function in the editor below. It must return the sum of the array elements as an integer.

simpleArraySum has the following parameter(s):

ar: an array of integers
Input Format

The first line contains an integer, , denoting the size of the array.
The second line contains  space-separated integers representing the array's elements.

Constraints


Output Format

Print the sum of the array's elements as a single integer.

Sample Input

6
1 2 3 4 10 11
Sample Output

31
Explanation

We print the sum of the array's elements: .

Language
C#
More
2425262737282930313233343536383940
        {
            sum += ar[i];
        }

        // Return the calculated sum
        return sum;

    }

}

Line: 36 Col: 20

Test against custom input
Congratulations!

You have passed the sample test cases. Click the submit button to run your code against all the test cases.


Sample Test case 0
Input (stdin)
6
1 2 3 4 10 11
Your Output (stdout)
31
Expected Output
31

using System;
using System.Collections.Generic;

namespace Soln
{
    class Result
    {
        
         * Complete the 'simpleArraySum' function below.
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY ar as parameter.
        
using Soln;

public static int simpleArraySum(List<int> ar)
{
int sum = 0;

// Use a for loop to iterate through the list
for (int i = 0; i < ar.Count; i++)
{
sum += ar[i];
}

// Return the calculated sum
return sum;
}
    }

    class Solution
{
    public static void Main(string[] args)
    {
        // Read the size of the array
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        // Initialize a list to store integers
        List<int> ar = new List<int>();

        // Read each integer input on a new line
        for (int i = 0; i < arCount; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine().Trim());
            ar.Add(num);
        }

        // Calculate the sum of the array elements
        int result = Result.simpleArraySum(ar);

        // Print the result
        Console.WriteLine(result);
    }
}
}



 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Soln
{
    class Result
    {
        /*
         * Complete the 'simpleArraySum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY ar as parameter.
         */
        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;

            // Use a for loop to iterate through the list
            /*for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }*/

            foreach (int i in ar)
            {
                sum += i;
            }

            // Return the calculated sum
            return sum;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            // Read input for the array size (not used in logic but part of input format)
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            // Read the array elements from the input
            List<int> ar = Console.ReadLine()
                                  .TrimEnd()
                                  .Split(' ')
                                  .ToList()
                                  .Select(arTemp => Convert.ToInt32(arTemp))
                                  .ToList();

            // Calculate the sum of the array elements
            int result = Result.simpleArraySum(ar);

            // Print the result
            Console.WriteLine(result);
        }
    }
}

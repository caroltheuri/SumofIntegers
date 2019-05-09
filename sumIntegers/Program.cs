using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given an array of integers, return indices of the two numbers such that they add up to a specific
            // target.

            /* first case: Start with the first element and loop through the array to get the sum */
            /* If the sum is the target then break */
            /* second case: Start with the second element and loop through the entire array and try to get the sum and continue*/
            /* If the sum is the target then break */
            /* If the integers in the array do not add upto the target display a warning*/
            int[] arr1 = { 2,11,15,7};
            int sum =0 ;
            int index1 = 0;
            int index2 = 0;
            int target = 9;
            for (int i=0; i<arr1.Length;i++)
            {

                for (int j = i + 1; j < arr1.Length; j++)
                {
                    sum = arr1[i] + arr1[j];
                    if (sum == target && j < arr1.Length)
                    {
                        Console.WriteLine(i + "," + j);
                        index1 = i;
                        index2 = j;
                        Console.WriteLine(sum);
                    }
                    
                }

            }
            if (index2 == 0 && index2 == 0)
            {
                Console.WriteLine("no integers with the tageted sum could be found");
            }
            Console.Read();
        }
    }
}

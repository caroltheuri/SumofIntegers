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
            int[] arr1 = { 2,11,7,15};
            int sum = 0;
            int target = 9;
            int start = arr1[0];
            for (int i=0; i<arr1.Length-1;i++)
            {
                sum = start + arr1[i];
                if (sum == target)
                {
                    Console.WriteLine(0 + "," + i);
                    
                }
                for (int j=i+1; j < arr1.Length - 1; j++)
                {
                    sum = arr1[i] + arr1[j];
                    if (sum == target)
                    {
                        Console.WriteLine(arr1[i] + "," +  arr1[j]);

                    }
                    //else
                    //{
                    //    Console.WriteLine("No integers with the tageted sum could be found");
                    //}
                }
            }
            Console.Read();
        }
    }
}

using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = SumArray(nums, 0);

            Console.WriteLine(sum);
        }


        public static int SumArray(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }

            return arr[index] + SumArray(arr, index + 1);
        }
    }
}

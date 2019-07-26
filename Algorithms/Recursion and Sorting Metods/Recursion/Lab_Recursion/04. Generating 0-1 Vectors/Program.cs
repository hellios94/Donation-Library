using System;

namespace _04._Generating_0_1_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            PrintVector(0, arr);
        }

        public static void PrintVector(int index, int[] arr)
        {
            if(index == arr.Length )
            {
                Console.WriteLine(String.Join("", arr));
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    arr[index] = i;

                    PrintVector(index + 1, arr);
                }
            }
        }
    }
}

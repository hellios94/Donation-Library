using System;

namespace _02._Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long sum = Factoriel(n);

            Console.WriteLine(sum);
        }


        public static long Factoriel(int n)
        {
            if(n == 0)
            {
                return 1;
            }

            long sum = n * Factoriel(n - 1);

            return sum;
        }
    }
}

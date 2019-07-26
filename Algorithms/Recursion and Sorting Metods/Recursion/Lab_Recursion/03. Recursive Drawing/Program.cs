using System;

namespace _03._Recursive_Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Print(n);
        }


        public static string Print(int n)
        {

            if(n == 0)
            {
                return "";
            }

            Console.WriteLine(new string('*', n));

            Print(n - 1);

            Console.WriteLine(new string('#', n));

            return "";
        }
    }
}

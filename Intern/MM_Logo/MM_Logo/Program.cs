using System;

namespace MM_Logo
{
    class Program
    {
         static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintLogo(n);
        }


        

         static void PrintLogo(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if(i == 0)
                {
                    FirtstLine.PrintFirstLine(n);
                }
                else
                {
                    OtherLine.PrintLine(n, i);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Logo
{
    public class FirtstLine
    {

        static void PrintFirstLineStar(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
        }

        static void PrintFirstLineLines(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("-");
            }
        }

        public static void PrintFirstLine(int n)
        {
            PrintFirstLineLines(n);
            PrintFirstLineStar(n);
            PrintFirstLineLines(n);
            PrintFirstLineStar(n);
            PrintFirstLineLines(n);
            PrintFirstLineLines(n);
            PrintFirstLineStar(n);
            PrintFirstLineLines(n);
            PrintFirstLineStar(n);
            PrintFirstLineLines(n);
        }

    }
}

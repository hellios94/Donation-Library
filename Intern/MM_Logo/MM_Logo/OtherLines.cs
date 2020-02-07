using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Logo
{
    public class OtherLine
    {

        private static int starConst = 0;
        private static int lineConst = 0;

         static void PrintStars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
        }

         static void PrintLines(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("-");
            }
        }

        public static void PrintLine(int n, int row)
        {

            if(row < (n + 1) / 2)
            {
                starConst += 2;
                lineConst += 2;

                PrintLines(n - row);
                PrintStars(n + starConst);
                PrintLines(n - lineConst);
                PrintStars(n + starConst);
                PrintLines((n - row) * 2);
                PrintStars(n + starConst);
                PrintLines(n - lineConst);
                PrintStars(n + starConst);
                PrintLines(n - row);

            }
            else if(row == n)
            {
                PrintStars(n);
                PrintLines(n);
                PrintStars(n);
                PrintLines(n);
                PrintStars(n * 2);
                PrintLines(n);
                PrintStars(n);
                PrintLines(n);
                PrintStars(n);
            }

            else
            {
                

                PrintLines(n - row);
                PrintStars(n);
                PrintLines(n - lineConst);
                PrintStars(n + starConst);
                PrintLines(n - lineConst);
                PrintStars(n);
                PrintLines((n - row) * 2);
                PrintStars(n);
                PrintLines(n - lineConst);
                PrintStars(n + starConst);
                PrintLines(n - lineConst);
                PrintStars(n);
                PrintLines(n - row);

                starConst -= 2;
                lineConst -= 2;
            }
            
        }
    }
}

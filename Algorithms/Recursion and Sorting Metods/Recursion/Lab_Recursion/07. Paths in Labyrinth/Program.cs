using System;

namespace _07._Paths_in_Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[] chars = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                chars[i] = Console.ReadLine();
            }

            char[,] labirint = new char[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    labirint[row, col] = chars[row][col];
                }
            }

            FindPath(labirint, 0, 0, ' ', "");
        }


        static void FindPath(char[,] labirint, int row, int col, char mark, string path)
        {

            if(!IsInArray(labirint, row, col))
            {
                return;
            }
            path += mark;
            if (labirint[row,col] == 'e')
            {

                Console.WriteLine(path.Trim());
            }
            else if(IsPassable(labirint, row, col))
            {
                labirint[row,col] = mark;
                FindPath(labirint, row, col + 1, 'R', path); // Right;
                FindPath(labirint, row, col - 1, 'L', path); // Left;
                FindPath(labirint, row + 1, col, 'D', path); // Down;
                FindPath(labirint, row - 1, col, 'U', path); // Up;
                UnMarked(labirint, row, col, path);
            }
            

        }


        static bool IsInArray(char[,] labirint, int row, int col)
        {
            int lenght = labirint.GetLength(0);
            int height = labirint.GetLength(1);

            if (row < 0 || row >= lenght)
            {
                return false;
            }
            if(col < 0 || col >= height)
            {
                return false;
            }

            return true;
        }

        static bool IsPassable(char[,] labirint, int row, int col)
        {
            if (labirint[row, col] == '-' && IsInArray(labirint, row, col) || labirint[row, col] == 'e')
            {
                return true;
            }

            return false;
        }

        static bool CanMove(char[,] labirint, int row, int col)
        {
            if (IsInArray(labirint, row + 1, col) && IsPassable(labirint, row + 1, col))
            {
                return true;
            }
            else if (IsInArray(labirint, row - 1, col) && IsPassable(labirint, row - 1, col))
            {
                return true;
            }
            else if(IsInArray(labirint, row, col - 1) && IsPassable(labirint, row, col - 1))
            {
                return true;
            }
            else if(IsInArray(labirint, row, col + 1) && IsPassable(labirint, row, col + 1))
            {
                return true;
            }

            return false;
        }

        static char[,] UnMarked(char[,] labirint, int row, int col, string path)
        {
            if(!CanMove(labirint, row, col))
            {
                labirint[row,col] = '-';
                path.Remove(path.Length - 1, 1);
            }

            return labirint;
        }

        //static bool IsVisited(char[,] labirint, int row, int col)
        //{
        //    if(labirint[row,col] == '-')
        //    {
        //        return false;
        //    }

        //    return true;
        //}
    }
}

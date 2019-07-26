using System;

namespace _06._8_Queens_Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[8, 8];

            int queen = 1;

            PutQueen(board, 0, queen);
        }



        static void PutQueen(int [,] board, int row, int queen)
        {
            if(row == 8)
            {
                PrintBoard(board);
            }
            else
            {
                for (int col = 0; col <= 7; col++)
                {
                    if (CanPlaceQueen(board, row, col))
                    {
                        board[row, col] = queen;
                        MarkAtackPositions(board, row, col, queen * 10);
                        PutQueen(board, row + 1, queen + 1);
                        board[row, col] = 0;
                        UnmarkAttackPosition(board, row, col, queen * 10);
                    }
                }
            }

            
        }

        static bool CanPlaceQueen(int[,] board, int row, int col)
        {
            if(board[row, col] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static int[,] MarkAtackPositions(int[,] board, int row, int col, int attacked)
        {


            for (int r = row; r < board.GetLength(0); r++)
            {
                if (board[r, col] == 0)
                {
                    board[r, col] = attacked;
                }
            }
            if (row > 0)
            {
                for (int r = row; r >= 0; r--)
                {
                    if (board[r, col] == 0)
                    {
                        board[r, col] = attacked;
                    }
                }
            }


            for (int c = col; c < board.GetLength(1); c++)
            {
                if (board[row, c] == 0)
                {
                    board[row, c] = attacked;
                }
            }

            if (col > 0)
            {
                for (int c = col; c >= 0; c--)
                {
                    if (board[row, c] == 0)
                    {
                        board[row, c] = attacked;
                    }
                }
            }

            int index = col - 1;
            for (int r = row; r < board.GetLength(0) - 1; r++)
            {
                index++;
                for (int c = col; c < board.GetLength(1) - 1; c++)
                {
                    if (board[r + 1, c + 1] == 0 && c == index)
                    {
                        board[r + 1, c + 1] = attacked;
                    }
                }
            }


                int index1 = col + 1;
                for (int r = row; r > 0; r--)
                {
                    index1--;
                    for (int c = col; c > 0; c--)
                    {
                        if (board[r - 1, c - 1] == 0 && c == index1)
                        {
                            board[r - 1, c - 1] = attacked;
                        }
                    }
                }

            int index2 = col - 1;
            for (int r = row; r > 0; r--)
            {
                index2++;
                for (int c = col; c < board.GetLength(1) - 1; c++)
                {
                    if (board[r - 1, c + 1] == 0 && c == index2)
                    {
                        board[r - 1, c + 1] = attacked;
                    }
                }
            }

            int index3 = col + 1;
            for (int r = row; r < board.GetLength(0) - 1; r++)
            {
                index3--;
                for (int c = col; c > 0; c--)
                {
                    if (board[r + 1, c - 1] == 0 && c == index3)
                    {
                        board[r + 1, c - 1] = attacked;
                    }
                }
            }
                return board;
        }

        static int[,] UnmarkAttackPosition(int[,] board, int row, int col, int attacked)
        {
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    if (board[r, c] == attacked)
                    {
                        board[r, c] = 0;
                    }
                }
            }

            return board;
        }

        static void PrintBoard(int[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if(col != board.GetLength(1) - 1)
                    {
                        if(board[row, col] == 1 || board[row, col] == 2 || board[row, col] == 3 ||
                            board[row, col] == 4 || board[row, col] == 5 || board[row, col] == 6 ||
                            board[row, col] == 7 || board[row, col] == 8)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    else
                    {
                        if (board[row, col] == 1 || board[row, col] == 2 || board[row, col] == 3 ||
                            board[row, col] == 4 || board[row, col] == 5 || board[row, col] == 6 ||
                            board[row, col] == 7 || board[row, col] == 8)
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}

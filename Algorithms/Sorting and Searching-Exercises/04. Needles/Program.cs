using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Needles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] field = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(String.Join(" ", Needles(field, nums)));
        }



        static List<int> Needles(int[] field, int[] nums)
        {
            
            List<int> indexes = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int numIndex = 0;
                for (int j = 0; j < field.Length; j++)
                {
                    if(field[j] != 0)
                    {
                        numIndex = j;
                    }

                   if(j < field.Length - 1)
                   {
                        if(nums[i] <= field[j] && field[j] != 0)
                        {
                            indexes.Add(j);
                            break;
                        }

                        if(field[j] == 0 & field[j + 1] != 0)
                        {
                            if(nums[i] <= field[j + 1])
                            {
                                indexes.Add(numIndex + 1);
                                break;
                            }
                        }
                   }

                   if(j == field.Length - 1)
                    {
                        if(nums[i] == field[j])
                        {
                            indexes.Add(j);
                        }
                        else
                        {
                            indexes.Add(j + 1);
                        }
                    }
                }
            }

            return indexes;
        }
    }
}

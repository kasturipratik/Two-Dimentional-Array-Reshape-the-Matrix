using System;
using System.Collections.Generic;

namespace Two_Dimentional_Array_Reshape_the_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[2][] { new int[2] { 1, 2 }, new int[2] { 3, 4} };
            int r = 1, c = 4;

            var newM = MatrixReshape(nums, r, c);

            var arrayNum = new int[] { 1, 2, 3 };
            
            Console.WriteLine(ConvertOneDimensionalArrayToTwo(arrayNum, 1, 3));
            Console.Write(newM);
        }

      
        // reshape matrix from 2 dimesional to one
        public static int[][] MatrixReshape(int[][] nums, int r, int c)
        {               
                if(nums.Length == 0 || c*r != nums.Length * nums[0].Length)
                {
                    return nums;
                }
            
                int [][] newArrays = new int[r][];
                
                var newArray = new int[r * c];
                var count = 0;
                for (int co = 0; co < nums.Length; co++)
                {
                    for(int i =0; i< nums[0].Length; i++)
                    {
                        newArray[count] = nums[co][i];
                        count++;
                    }
                }

            count = 0;
            for (int co = 0; co < r; co++)
            {
                newArrays[co] = new int[c];
                for (int i = 0; i < c; i++)
                {
                    newArrays[co][i] = newArray[count];
                    count++;
                }
            }
            
            return newArrays;
        }

        public static int[][] ConvertOneDimensionalArrayToTwo(int[] nums, int r, int c) 
        {
            if (nums.Length == 0 || c * r != nums.Length)
            {
                return new int[0][];
                
            }
            int[][] newArrays = new int[r][];

            var count = 0;
            for(int i =0; i < r; i++)
            {
                newArrays[i] = new int[c];
                for(int j =0; j < c; j++)
                {
                    newArrays[i][j] = nums[count];
                    count++;
                }
            }

            return newArrays;
        }
    }
}

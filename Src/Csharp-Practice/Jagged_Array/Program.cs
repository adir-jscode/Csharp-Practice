using System;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[3];

            int[][] jagged = new int[3][];

            jagged[0] = new[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            jagged[1] = new[] { 12, 13, 14, 15, 100 };

            for (int i = 0; i < jagged.Length; i++) // row
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine("Element No [" + i + "] [" + j + "] = " + jagged[i][j]);
                }
            }

            foreach (int[] item in  jagged)
            {
                foreach(int numbers in item)
                {
                    Console.Write(numbers + " , ");
                }
                Console.WriteLine();
            }

        }
    }
}
using System;

namespace Multidimentional_Array
{

    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[3, 4]
            {
                { 11,22,33,44},
                { 10,20,30,40},
                { 15,25,35,45}
            };

            for(int i = 0; i < arr.GetLength(0); i++) //ROW
            {
                for(int j = 0; j < arr.GetLength(1); j++) // Column
                {
                    Console.WriteLine(arr[i,j] + " " + arr[i,j] * arr[i,j] );
                }
            }

            Console.WriteLine("Array Dimention is " + arr.Rank); // Returns diamension

           



        }
    }
    
}
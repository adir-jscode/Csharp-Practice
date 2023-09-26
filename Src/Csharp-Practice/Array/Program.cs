using System;

namespace Array
{
    class Program
    {
        static void Main(string[]args)
        {
            int[] arr = new int[4];

            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;

            Console.WriteLine(arr[0]);


            string[] names = { "Hasan", "Hossain","Ali","Adir","Sarafat" };

            Console.WriteLine(names[1]);

            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Index NO " + i + " = " + arr[i]);
            }

            for(int i=0; i<names.Count(); i++)
            {
                Console.WriteLine("Person No " + (i + 1) + " = " + names[i]);
            }

            foreach(string namelist in names)
            {
                Console.WriteLine(namelist);
            }



        }
    }
}
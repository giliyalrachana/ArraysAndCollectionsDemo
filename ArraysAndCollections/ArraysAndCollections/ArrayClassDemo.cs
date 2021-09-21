using System;


namespace ArraysAndCollections
{
    // This program demo. how to use functionalities of array base class.
    class ArrayClassDemo
    {
        static void Main()
        {
            int[] numsArray = { 10, 20, 30, 40, 50 };
            int[] dumsArray = new int[5];
            int[,] numsArray1 = new int[3, 7];

            // How to copy elements from one array to another
            numsArray.CopyTo(dumsArray, 0);
            Console.WriteLine("After copying elements from numsArray to dumsArray");
            foreach (var nums in dumsArray)
            {
                Console.WriteLine($"{nums}\t");
            }

            // How to set an element at specific location
            dumsArray.SetValue(99, 4);

            // How to get an element from specific location
            Console.WriteLine($"Value at Indext 4 is: { dumsArray.GetValue(4)} { dumsArray[4]}");

            // How to get Upperbound and Lowerbound
            Console.WriteLine($"Upperbound is:{dumsArray.GetUpperBound(0)} Lowerbound = {dumsArray.GetLowerBound(0)}");
            Console.WriteLine($"Upperbound of numsArray1 is:{numsArray1.GetUpperBound(1)} Lowerbound = {numsArray1.GetLowerBound(1)}");

            // How to get the Length
            Console.WriteLine($"dumsArray Length is : {dumsArray.Length} and numsArray1 Length of Second dim. is {numsArray1.GetLength(1)}");

            // How to get no. of dimensions of an array
            Console.WriteLine($"No. of dim. in numsArray1 is : {numsArray1.Rank}");

            // How to sort an array
            Array.Sort(dumsArray);
            Console.WriteLine("After sorting elements from numsArray to dumsArray");
            foreach (var nums in dumsArray)
            {
                Console.WriteLine($"{nums}\t");
            }

            // How to revere an array
            Array.Reverse(dumsArray);
            Console.WriteLine("After reverseing elements from numsArray to dumsArray");
            foreach (var nums in dumsArray)
            {
                Console.WriteLine($"{nums}\t");
            }

            // How to get an index by passing value
            Console.WriteLine($"Index of 99 is : {Array.IndexOf(dumsArray, 99)}");

            // How to clear elements
            Array.Clear(dumsArray, 0, 3);
            Console.WriteLine("After clearing elements from numsArray to dumsArray");
            foreach (var nums in dumsArray)
            {
                Console.WriteLine($"{nums}\t");
            }


            Console.ReadLine();

        }
    }
}

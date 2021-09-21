using System;


namespace ArraysAndCollections
{
    class CJaggedArray
    {
        static void Main()
        {
            // This is the syntax to declare Single dim. jagged array
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 10, 20, 30 };
            jaggedArray[1] = new int[] { 40, 50 };
            //jaggedArray[0] = new int[3];
            //jaggedArray[1] = new int[2];

            for (int i = 0; i < 2; i++)
            {
                foreach (var nums in jaggedArray[i])
                {
                    Console.Write($"{nums}\t");
                }
                Console.WriteLine();
            }
            // This is the syntax to declare multi dim. jagged array
            int[][ , ] jaggedArray1 = new int[2][,]
            {
                new int[ , ]{ { 10, 20, 30 }, { 40, 50, 60 } },
                new int[ , ]{ { 1, 2, 3 }, { 4, 5, 6 } }
            };
            // print multi dim. array
            

            Console.ReadLine();
        }
    }
}

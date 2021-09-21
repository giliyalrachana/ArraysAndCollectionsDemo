using System;


namespace ArraysAndCollections
{
    // This program Demo. overview of an array
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 10, 20, 30, 40, 50 };
            numsArray[0] = 11;
            Console.WriteLine($"numsArray[0]={numsArray[0]}");

            foreach (var num in numsArray)
            {
                Console.Write($"{num}\t");
            }
            Console.WriteLine();

            string[] strArray = { "string1", "string2", "string3","string4","string5" };
            strArray[0] = "New String";
            Console.WriteLine($"strArray[0]={strArray[0]}");

            foreach (var str in strArray)
            {
                Console.Write($"{str}\t");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;


namespace ArraysAndCollections
{
    // This program demo. how to use ArrayList
    class ArrayListDemo
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("Scott");
            arrayList.Add('M');
            arrayList.Add(true);
            // arrayList.Insert(1,100);

            Console.WriteLine($"Count={arrayList.Count} Capacity={arrayList.Capacity}");
            foreach (var v in arrayList)
            {
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }
    }
}

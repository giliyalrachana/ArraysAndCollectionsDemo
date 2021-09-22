using System;
using System.Collections;

namespace ArraysAndCollections
{
    // This program demo. how to use Queue
    class QueueDemo
    {
        static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(1001);
            queue.Enqueue(1002);
            queue.Enqueue(1003);
            queue.Enqueue(1004);
            queue.Enqueue(1005);

            Console.WriteLine($"Count is : {queue.Count}");
            foreach (var v in queue)
            {
                Console.WriteLine(v);
            }
            
            Console.WriteLine($"After removing an element:{ queue.Dequeue()}");
            foreach (var v in queue)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine($"Next element to be removed:{ queue.Peek()}");
            foreach (var v in queue)
            {
                Console.WriteLine(v);
            }
            queue.Clear();
            Console.ReadLine();
        }

    }
}
    


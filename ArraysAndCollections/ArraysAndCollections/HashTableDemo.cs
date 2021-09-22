using System;
using System.Collections;


namespace ArraysAndCollections
{
    class HashTableDemo
    {
        static void Main()
            Hashtable hashtable = new Hashtable();
            hashtable.Add("MH",27);
            hashtable.Add("GJ",24);
            hashtable.Add("DL",12);
            hashtable.Add("TL",29);
            hashtable.Add("KA",37);

            Console.WriteLine($"GST state code for Maharastra is : {hashtable["MH"]}");

    }
}

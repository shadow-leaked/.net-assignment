using System;
using System.Collections;

namespace ArrayListAndDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList Example
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add("Four");
            arrayList.Add(5.5);

            Console.WriteLine("ArrayList contents:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(); // Blank line for readability

            // Dictionary Example
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary["Apple"] = 1;
            dictionary["Banana"] = 2;
            dictionary["Cherry"] = 3;

            Console.WriteLine("Dictionary contents:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.ReadLine();
        }
    }
}

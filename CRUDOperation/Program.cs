using System.Collections;

namespace CRUDOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CRUD Operation !");
            ArrayList myList = new ArrayList();

            // Create - Adding elements to the ArrayList
            myList.Add("Apple");
            myList.Add("Banana");
            myList.Add("Cherry");

            // Read - Accessing elements from the ArrayList
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            // Update - Modifying elements in the ArrayList
            myList[1] = "Mango";

            Console.WriteLine("\nUpdated ArrayList:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            // Delete - Removing elements from the ArrayList
            myList.Remove("Cherry");

            Console.WriteLine("\nArrayList after removing an element:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("/*****************************************************************************/");
            Console.WriteLine("/*****************************************************************************/");


            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            // Create - Adding key-value pairs to the Dictionary
            myDictionary.Add(1, "Apple");
            myDictionary.Add(2, "Banana");
            myDictionary.Add(3, "Cherry");

            // Read - Accessing values from the Dictionary using keys
            Console.WriteLine("Dictionary values:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Update - Modifying values in the Dictionary
            myDictionary[2] = "Mango";

            Console.WriteLine("\nUpdated Dictionary values:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Delete - Removing key-value pairs from the Dictionary
            myDictionary.Remove(3);

            Console.WriteLine("\nDictionary values after removing a key-value pair:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
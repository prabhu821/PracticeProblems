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
        }
    }
}
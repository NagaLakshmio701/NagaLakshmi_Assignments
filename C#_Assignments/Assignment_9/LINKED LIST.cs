using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new linked list of integers
        LinkedList<int> linkedList = new LinkedList<int>();

        // Add elements to the linked list
        linkedList.AddLast(10);
        linkedList.AddLast(20);                    //ADDING ELEMENTS AT LAST
        linkedList.AddLast(30);

        // Print the elements in the linked list
        foreach (int value in linkedList)
        {
            Console.WriteLine(value);

        }

        Console.WriteLine();
        
        linkedList.AddFirst(100);
        linkedList.AddFirst(200);                //ADDING ELEMENTS AT FIRST
        linkedList.AddFirst(300);

        foreach (int value in linkedList)
        {
            Console.WriteLine(value);

        }

        Console.WriteLine();
        // Find the node with value 20
        LinkedListNode<int> node = linkedList.Find(20);     //ADDING ELEMENT BEFORE AND AFTER A SPECIFIC NODE

        linkedList.AddBefore(node, 1);
        linkedList.AddAfter(node, 2);

        foreach (int value in linkedList)
        {
            Console.WriteLine(value);

        }

        Console.WriteLine();

        //REMOVE ELEMENTS

        linkedList.Remove(20);              // Removes the first occurrence of 20
        linkedList.RemoveFirst();           // Removes the first node
        linkedList.RemoveLast();            // Removes the last node
        /*        linkedList.Clear();                 // Removes all nodes
        */
        Console.WriteLine("AFTER REMOVING ELEMENTS");

        foreach (int value in linkedList)
        {
            Console.WriteLine(value);

        }


        Console.WriteLine();

        LinkedListNode<int> findNode = linkedList.Find(10);// Finds the first occurrence of 30
        LinkedListNode<int> findLastNode = linkedList.FindLast(30); // Finds the last occurrence of 30


        int count = linkedList.Count;
        Console.WriteLine($"Count: {count}"); // Prints the number of elements in the linked list




    }
}

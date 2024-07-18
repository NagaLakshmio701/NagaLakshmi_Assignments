using System;
using System.Collections.Generic;

class Program2
{
    static void Main()
    {
        // Create a new HashSet of integers
        HashSet<int> hashSet = new HashSet<int>();

        // Add elements to the HashSet
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        hashSet.Add(3);  // Duplicate, will not be added

        Console.WriteLine("Initial HashSet:");
        PrintHashSet(hashSet);

        // Remove an element
        hashSet.Remove(2);
        Console.WriteLine("\nAfter removing 2:");
        PrintHashSet(hashSet);

        // Check for existence
        bool contains = hashSet.Contains(3);
        Console.WriteLine($"\nContains 3: {contains}");

        // Get the count
        int count = hashSet.Count;
        Console.WriteLine($"\nCount: {count}");

        // Clear the HashSet
        hashSet.Clear();
        Console.WriteLine("\nAfter clearing:");
        PrintHashSet(hashSet);

        // Set operations
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4 };
        HashSet<int> set2 = new HashSet<int>() { 3, 4, 5, 6 };

        set1.UnionWith(set2);
        Console.WriteLine("\nAfter UnionWith:");
        PrintHashSet(set1);

        set1 = new HashSet<int>() { 1, 2, 3, 4 };
        set1.IntersectWith(set2);
        Console.WriteLine("\nAfter IntersectWith:");
        PrintHashSet(set1);

        set1 = new HashSet<int>() { 1, 2, 3, 4 };
        set1.ExceptWith(set2);
        Console.WriteLine("\nAfter ExceptWith:");
        PrintHashSet(set1);

        set1 = new HashSet<int>() { 1, 2, 3, 4 };
        set1.SymmetricExceptWith(set2);
        Console.WriteLine("\nAfter SymmetricExceptWith:");
        PrintHashSet(set1);
    }

    static void PrintHashSet(HashSet<int> hashSet)
    {
        foreach (int value in hashSet)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}

/*Given an array of n elements that contains elements from 0 to n-1, with any of these numbers appearing any number of times. Find these repeating numbers in O(n) and use only constant memory space.*/

/*Store Frequency in dictionary , store the frequencies more than 1 in another list, return that list*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> Duplicates(int[] arr)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        List<int> duplicates = new List<int>();

        // Count the frequency of each element
        foreach (int num in arr)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }

        // Check for elements with frequency greater than 1 (duplicates)
        foreach (var pair in frequency)
        {
            if (pair.Value > 1)
            {
                duplicates.Add(pair.Key);
            }
        }

        return duplicates;
    }

    static void Main(string[] args)
    {
        int[] arr = {1, 6, 3, 1, 3, 6, 6};

        List<int> ans = Duplicates(arr);
        if (ans.Count == 0)
        {
            Console.WriteLine("No duplicates found.");
        }
        else
        {
            Console.WriteLine("The repeating elements are:");
            foreach (int num in ans)
            {
                Console.Write(num + " ");
            }
        }
    }
}
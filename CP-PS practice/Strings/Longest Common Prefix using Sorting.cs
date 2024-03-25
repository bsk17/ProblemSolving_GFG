/*
Given a set of strings, find the longest common prefix.
Examples:

Input: {“geeksforgeeks”, “geeks”, “geek”, “geezer”}
Output: “gee”

Input: {“apple”, “ape”, “april”}
Output: “ap”
*/

/*
In this post, a new method based on sorting is discussed. The idea is to sort the array of strings and find the common prefix of the first and last string of the sorted array.
*/
using System;
		
public class GFG {
	
	static string longestCommonPrefix(String[] a)
	{
		int size = a.Length;

		/* if size is 0, return empty string */
		if (size == 0)
			return "";

		if (size == 1)
			return a[0];

		/* sort the array of strings */
		Array.Sort(a);

		/* find the minimum length from first
		and last string */
		int end = Math.Min(a[0].Length,
							a[size-1].Length);

		/* find the common prefix between the 
		first and last string */
		int i = 0;
		while (i < end && a[0][i] == a[size-1][i] )
			i++;

		string pre = a[0].Substring(0, i);
		return pre;
	}

	/* Driver Function to test other function */
	public static void Main()
	{
		
		string[] input = {"geeksforgeeks", "geeks",
								"geek", "geezer"};
								
		Console.WriteLine( "The longest Common"
							+ " Prefix is : "
				+ longestCommonPrefix(input));
	}
}

// This code is contributed by Sam007.

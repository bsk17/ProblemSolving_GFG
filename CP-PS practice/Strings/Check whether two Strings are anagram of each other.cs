/*
Given two strings. The task is to check whether the given strings are anagrams of each other or not. An anagram of a string is another string that contains the same characters, only the order of characters can be different. For example, “abcd” and “dabc” are an anagram of each other.

Examples:

Input: str1 = “listen”  str2 = “silent”
Output: “Anagram”
Explanation: All characters of “listen” and “silent” are the same.

Input: str1 = “gram”  str2 = “arm”
Output: “Not Anagram”
*/

/*
APPROACH:1 - Sort the two given strings and compare, if they are equal then they are anagram of each other.
Time Complexity: O(N * logN), For sorting.
Auxiliary Space: O(1) as it is using constant extra space
*/

using System;
using System.Collections;
class GFG {

	/* function to check whether two
strings are anagram of each other */
	public static bool areAnagram(ArrayList str1,
								ArrayList str2)
	{
		// Get lengths of both strings
		int n1 = str1.Count;
		int n2 = str2.Count;

		// If length of both strings is not
		// same, then they cannot be anagram
		if (n1 != n2) {
			return false;
		}

		// Sort both strings
		str1.Sort();
		str2.Sort();

		// Compare sorted strings
		for (int i = 0; i < n1; i++) {
			if (str1[i] != str2[i]) {
				return false;
			}
		}

		return true;
	}

	// Driver Code
	public static void Main(string[] args)
	{
		// create and initialize new ArrayList
		ArrayList str1 = new ArrayList();
		str1.Add('g');
		str1.Add('r');
		str1.Add('a');
		str1.Add('m');
		// create and initialize new ArrayList
		ArrayList str2 = new ArrayList();
		str2.Add('a');
		str2.Add('r');
		str2.Add('m');

		// Function call 
		if (areAnagram(str1, str2)) {
			Console.WriteLine("The two strings are"
							+ " anagram of each other");
		}
		else {
			Console.WriteLine("The two strings are not"
							+ " anagram of each other");
		}
	}
}

/*
APPROACH:2 - The idea is based in an assumption that the set of possible characters in both strings is small. that the characters are stored using 8 bit and there can be 256 possible characters. 

So count the frequency of the characters and if the frequency of characters in both strings are the same, they are anagram of each other.

Time Complexity: O(n)
Auxiliary Space: O(256) i.e. O(1) for constant space.
*/


using System;

public class GFG {

	static int NO_OF_CHARS = 256;

	/* function to check whether two strings
	are anagram of each other */
	static bool areAnagram(char[] str1, char[] str2)
	{
		// Create 2 count arrays and initialize
		// all values as 0
		int[] count1 = new int[NO_OF_CHARS];
		int[] count2 = new int[NO_OF_CHARS];
		int i;

		// For each character in input strings,
		// increment count in the corresponding
		// count array
		for (i = 0; i < str1.Length && i < str2.Length;
			i++) {
			count1[str1[i]]++;
			count2[str2[i]]++;
		}

		// If both strings are of different length.
		// Removing this condition will make the program
		// fail for strings like "aaca" and "aca"
		if (str1.Length != str2.Length)
			return false;

		// Compare count arrays
		for (i = 0; i < NO_OF_CHARS; i++)
			if (count1[i] != count2[i])
				return false;

		return true;
	}

	/* Driver code*/
	public static void Main()
	{
		char[] str1 = ("gram").ToCharArray();
		char[] str2 = ("arm").ToCharArray();

		// Function Call
		if (areAnagram(str1, str2))
			Console.WriteLine("The two strings are"
							+ " anagram of each other");
		else
			Console.WriteLine("The two strings are not"
							+ " anagram of each other");
	}
}

/*
APPROACH:3 - The idea is a modification of the above approach where instead of creating an array of 256 characters HashMap is used to store characters and count of characters in HashMap. Idea is to put all characters of one String in HashMap and reduce them as they are encountered while looping over other the string

Time Complexity: O(N)
Auxiliary Space: O(1), Hashmap uses an extra space 
*/

using System;
using System.Collections.Generic;

public class GFG {
	public static bool isAnagram(String a, String b)
	{

		// Check if length of both strings is same or not
		if (a.Length != b.Length) {
			return false;
		}

		// Create a Dictionary containing char as Key and
		// int as Value. We will be storing character as
		// Key and count of character as Value.
		Dictionary<char, int> map
			= new Dictionary<char, int>();

		// Loop over all character of String a and put in
		// Dictionary.
		for (int i = 0; i < a.Length; i++) {

			// Check if Dictionary already contain current
			// character or not
			if (map.ContainsKey(a[i])) {

				// If contains increase count by 1 for that
				// character
				map[a[i]] = map[a[i]] + 1;
			}
			else {

				// else put that character in map and set
				// count to 1 as character is encountered
				// first time
				map.Add(a[i], 1);
			}
		}

		// Now loop over String b
		for (int i = 0; i < b.Length; i++) {

			// Check if current character already exists in
			// Dictionary/map
			if (map.ContainsKey(b[i])) {

				// If contains reduce count of that
				// character by 1 to indicate that current
				// character has been already counted as
				// idea here is to check if in last count of
				// all characters in last is zero which
				// means all characters in String a are
				// present in String b.
				map[b[i]] = map[b[i]] - 1;
			}
			else {
				return false;
			}
		}

		// Extract all keys of Dictionary/map
		var keys = map.Keys;

		// Loop over all keys and check if all keys are 0.
		// If so it means it is anagram.
		foreach(char key in keys)
		{
			if (map[key] != 0) {
				return false;
			}
		}

		// Returning True as all keys are zero
		return true;
	}

	// Driver code
	public static void Main(String[] args)
	{
		String str1 = "gram";
		String str2 = "arm";

		// Function call
		if (isAnagram(str1, str2))
			Console.Write("The two strings are "
						+ "anagram of each other");
		else
			Console.Write("The two strings are "
						+ "not anagram of each other");
	}
}

// This code is contributed by shikhasingrajput

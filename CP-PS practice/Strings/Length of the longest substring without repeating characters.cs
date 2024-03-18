/*
Given a string str, find the length of the longest substring without repeating characters. 
*/

/*
Example 1:
Input: “ABCDEFGABEF”
Output: 7
Explanation: The longest substring without repeating characters are “ABCDEFG”, “BCDEFGA”, and “CDEFGAB” with lengths of 7

Example 2:
Input: “GEEKSFORGEEKS”
Output: 7
Explanation: The longest substrings without repeating characters are “EKSFORG” and “KSFORGE”, with lengths of 7
*/

/*
APPROACH-1 : Length of the longest substring without repeating characters using Sliding Window in O(n2) time:
For each index i, find the the length of longest substring without repeating characters starting at index i. This can be done by starting at index i, and iterating until the end of the string, if a repeating character is found before the end of string we will break else update the answer if the current substring is larger.
*/

// C# program to find the length of the
// longest substring without repeating
// characters
using System;

class GFG {

	static int longestUniqueSubsttr(string str)
	{
		int n = str.Length;

		// Result
		int res = 0;

		for (int i = 0; i < n; i++) {

			// Note : Default values in visited are false
			bool[] visited = new bool[256];

			// visited = visited.Select(i =>
			// false).ToArray();
			for (int j = i; j < n; j++) {

				// If current character is visited
				// Break the loop
				if (visited[str[j]] == true)
					break;

				// Else update the result if
				// this window is larger, and mark
				// current character as visited.
				else {
					res = Math.Max(res, j - i + 1);
					visited[str[j]] = true;
				}
			}

			// Remove the first character of previous
			// window
			visited[str[i]] = false;
		}
		return res;
	}

	// Driver code
	static void Main()
	{
		string str = "geeksforgeeks";
		Console.WriteLine("The input string is " + str);

		int len = longestUniqueSubsttr(str);
		Console.WriteLine("The length of the longest "
						+ "non-repeating character "
						+ "substring is " + len);
	}
}

/*
APPROACH-2: Time Complexity: O(n)
Intialize two pointers left and right with 0, which define the current window being considered.
The right pointer moves from left to right, extending the current window.
If the character at right pointer is not visited , it’s marked as visited.
If the character at right pointer is visited, it means there is a repeating character. The left pointer moves to the right while marking visited characters as false until the repeating character is no longer part of the current window.
The length of the current window (right - left + 1) is calculated and answer is updated accordingly.
*/

using System;

public class GFG {

	public static int LongestUniqueSubsttr(string str)
	{

		// if string length is 0
		if (str.Length == 0)
			return 0;

		// if string length 1
		if (str.Length == 1)
			return 1;

		// if string length is more than 2
		int maxLength = 0;
		bool[] visited = new bool[256];

		// left and right pointer of sliding window
		int left = 0, right = 0;
		while (right < str.Length) {

			// if character is visited
			if (visited[str[right]]) {

				// The left pointer moves to the right
				// while marking visited characters as
				// false until the repeating character
				// is no longer part of the current
				// window.
				while (visited[str[right]]) {

					visited[str[left]] = false;
					left++;
				}
			}

			visited[str[right]] = true;

			// The length of the current window (right -
			// left + 1) is calculated and the answer is
			// updated accordingly.
			maxLength
				= Math.Max(maxLength, right - left + 1);
			right++;
		}

		return maxLength;
	}

	// Driver code
	public static void Main(String[] args)
	{
		var str = "geeksforgeeks";
		Console.WriteLine("The input string is " + str);
		var len = GFG.LongestUniqueSubsttr(str);
		Console.WriteLine("The length of the longest "
						+ "non-repeating character "
						+ "substring is "
						+ len.ToString());
	}
}


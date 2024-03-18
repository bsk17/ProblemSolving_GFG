/*Given an array that contains both positive and negative integers, the task is to find the product of the maximum product subarray. */

/*
Input: arr[] = {6, -3, -10, 0, 2}
Output:  180
Explanation: The subarray is {6, -3, -10}

Input: arr[] = {-1, -3, -10, 0, 60}
Output:   60
Explanation: The subarray is {60}
*/

/*
APPROACH -1
Maximum Product Subarray by Traverse Over Every Contiguous Subarray: The idea is to traverse over every contiguous subarray, find the product of each of these subarrays and return the maximum product from these results.
*/

// C# program to find maximum product subarray
using System;

class GFG {

	// Returns the product of max product subarray
	static int maxSubarrayProduct(int[] arr)
	{

		// Initializing result
		int result = arr[0];
		int n = arr.Length;

		for (int i = 0; i < n; i++) {
			int mul = arr[i];

			// Traversing in current subarray
			for (int j = i + 1; j < n; j++) {

				// Updating result every time
				// to keep an eye over the
				// maximum product
				result = Math.Max(result, mul);
				mul *= arr[j];
			}

			// Updating the result for (n-1)th index
			result = Math.Max(result, mul);
		}
		return result;
	}

	// Driver Code
	public static void Main(String[] args)
	{
		int[] arr = { 1, -2, -3, 0, 7, -8, -2 };

		Console.Write("Maximum Sub array product is "
					+ maxSubarrayProduct(arr));
	}
}

/*
APPROACH-2: Maximum Product Subarray using Kadane’s Algorithm

The idea is to use Kadane’s algorithm and maintain 3 variables max_so_far, max_ending_here & min_ending_here. Iterate the indices 0 to N-1 and update the variables such that:

max_ending_here = maximum(arr[i], max_ending_here * arr[i], min_ending_here * arr[i])
min_ending_here = minimum(arr[i], max_ending_here * arr[i], min_ending_here * arr[i])
update the max_so_far with the maximum value for each index.
return max_so_far as the result.
*/


using System;

class GFG {

	/* Returns the product of max product subarray.
	Assumes that the given array always has a subarray
	with product more than 1 */
	static int maxSubarrayProduct(int[] arr)
	{
		// max positive product
		// ending at the current position
		int max_ending_here = arr[0];

		// min negative product ending
		// at the current position
		int min_ending_here = arr[0];

		// Initialize overall max product
		int max_so_far = arr[0];
		/* Traverse through the array.
		the maximum product subarray ending at an index
		will be the maximum of the element itself,
		the product of element and max product ending
		previously and the min product ending previously. */
		for (int i = 1; i < arr.Length; i++) {
			int temp = Math.Max(
				Math.Max(arr[i], arr[i] * max_ending_here),
				arr[i] * min_ending_here);
			min_ending_here = Math.Min(
				Math.Min(arr[i], arr[i] * max_ending_here),
				arr[i] * min_ending_here);
			max_ending_here = temp;
			max_so_far
				= Math.Max(max_so_far, max_ending_here);
		}
		return max_so_far;
	}

	// Driver Code
	public static void Main()
	{

		int[] arr = { 1, -2, -3, 0, 7, -8, -2 };

		Console.WriteLine("Maximum Sub array product is "
						+ maxSubarrayProduct(arr));
	}
}


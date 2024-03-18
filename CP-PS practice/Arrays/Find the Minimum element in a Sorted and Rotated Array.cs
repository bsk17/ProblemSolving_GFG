/*Given a sorted array arr[] (may be distinct or may contain duplicates) of size N that is rotated at some unknown point, the task is to find the minimum element in it.*/
/*
Input: arr[] = {5, 6, 1, 2, 3, 4}
Output: 1
Explanation: 1 is the minimum element present in the array.

Input: arr[] = {1, 2, 3, 4}
Output: 1
*/

/*
APPROACH - 1 : Simple Linear Search
*/
// C# code to implement above approach 
using System; 

class Minimum { 

	static int findMin(int[] arr, int N) 
	{ 
		int min_ele = arr[0]; 
		
		// Traversing over array to 
		// find minimum element 
		for (int i = 0; i < N; i++) { 
			if (arr[i] < min_ele) { 
				min_ele = arr[i]; 
			} 
		} 
		
		return min_ele; 
	} 

	// Driver Program 
	public static void Main() 
	{ 
		int[] arr = { 5, 6, 1, 2, 3, 4 }; 
		int N = arr.Length; 
		
		Console.WriteLine(findMin(arr, N)); 

	} 
} 

/*
APPROACH-2 : Using Binary Search to reduce time for lengthy arrays
*/
using System; 
using System.Collections.Generic; 

public class Program { 
public static int findMin(List<int> arr, int low, int high) { 
	// If the array is not rotated 
	if (arr[low] <= arr[high]) { 
	return arr[low]; 
	} 

	// Binary search 
	while (low <= high) { 
		int mid = (low + high) / 2; 

		// Check if mid is the minimum element 
		if (arr[mid] < arr[mid - 1]) { 
			return arr[mid]; 
		} 
		// If the left half is sorted, the minimum element must be in the right half 
		if (arr[mid] > arr[high]) { 
			low = mid + 1; 
		} 

		// If the right half is sorted, the minimum element must be in the left half 
		else { 
			high = mid - 1; 
		} 
	} 

	// If no minimum element is found, return -1 
	return -1; 
} 

// Driver program to test above functions 
public static void Main() { 
	List<int> arr = new List<int> {5, 6, 1, 2, 3, 4}; 
	int N = arr.Count; 
	Console.WriteLine("The minimum element is " + findMin(arr, 0, N - 1)); 
} 
} 


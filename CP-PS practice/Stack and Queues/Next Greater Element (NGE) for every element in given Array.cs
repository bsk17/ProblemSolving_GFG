/*
Given an array, print the Next Greater Element (NGE) for every element. 

The Next greater Element for an element x is the first greater element on the right side of x in the array. Elements for which no greater element exist, consider the next greater element as -1. 
*/

/*
The idea is to use two loops , The outer loop picks all the elements one by one. The inner loop looks for the first greater element for the element picked by the outer loop. If a greater element is found then that element is printed as next, otherwise, -1 is printed.
*/



using System;

class GFG {

	/* prints element and NGE pair for
	all elements of arr[] of size n */
	static void printNGE(int[] arr, int n)
	{
		int next, i , j;
		
		for(i=0; i<n; i++){
			next = -1;
			for(j=i+1; j<n; j++){
				if(arr[j] > arr[i]){
					next = arr[j];
					break;
				}
			}
			Console.WriteLine(arr[i] + "-->" + next);
		}
	}

	// driver code
	public static void Main()
	{
		int[] arr = { 11, 13, 21, 3 };
		int n = arr.Length;

		printNGE(arr, n);
	}
}

// This code is contributed by Sam007

/*
Given a sorted and rotated array arr[] of size N and a key, the task is to find the key in the array.

Note: Find the element in O(logN) time and assume that all the elements are distinct.
*/

/*
Input  : arr[] = {5, 6, 7, 8, 9, 10, 1, 2, 3}, key = 3
Output : Found at index 8
*/

/*
The idea is to create a recursive function to implement the binary search where the search region is [l, r]. For each recursive call:

We calculate the mid value as mid = (l + h) / 2
Then try to figure out if l to mid is sorted, or (mid+1) to h is sorted
Based on that decide the next search region and keep on doing this till the element is found or l overcomes h.
*/

using System;

class GFG{
	static int search(int[] arr, int low, int high, int key){
		if(low > high){
			return -1;
		}
		
		int mid = (low+high)/2;
		
		if(arr[mid] == key){
			return mid;
		}
		
		/* If arr[low...mid] is sorted */
		if(arr[low] <= arr[mid]){
			if(key > arr[low] && key <= arr[mid]){
				return search(arr, low, mid - 1, key);
			}
			return search(arr, mid + 1, high, key);
		}
		
		/* If arr[l..mid] is not sorted,
        then arr[mid... r] must be sorted*/
		if(key >= arr[mid] && key < arr[high]){
			return search(arr, mid + 1, high, key);
		}
		
		return search(arr, low, mid-1, key);
	}
	
	public static void Main(){
		
		int[] arr = {4,5,6,7,8,9,1,2,3};
		int n = arr.Length;
		int key = 3;
		int i = search(arr, 0, n-1, key);
		
		if(i != 1){
			Console.WriteLine("Key found at Index: "+i);
		}
		else
			Console.WriteLine("Key not Found");
	}
}
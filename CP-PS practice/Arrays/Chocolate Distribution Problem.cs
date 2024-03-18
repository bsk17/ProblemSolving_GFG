/*
Given an array of N integers where each value represents the number of chocolates in a packet. Each packet can have a variable number of chocolates. There are m students, the task is to distribute chocolate packets such that: 

Each student gets one packet.
The difference between the number of chocolates in the packet with maximum chocolates and the packet with minimum chocolates given to the students is minimum.
*/
/*
Input : arr[] = {7, 3, 2, 4, 9, 12, 56} , m = 3 
Output: Minimum Difference is 2 
Explanation:
We have seven packets of chocolates and we need to pick three packets for 3 students 
If we pick 2, 3 and 4, we get the minimum difference between maximum and minimum packet sizes.

Input : arr[] = {3, 4, 1, 9, 56, 7, 9, 12} , m = 5 
Output: Minimum Difference is 6 
*/

/*
The idea is based on the observation that to minimize the difference, we must choose consecutive elements from a sorted packet. We first sort the array arr[0..n-1], then find the subarray of size m with the minimum difference between the last and first elements.
*/

using System;

class GFG{
	static int findMinDiff(int[] arr, int length, int students){
		// if there are no chocolates or
        // number of students is 0
        if (m == 0 || n == 0)
            return 0;
 
        // Sort the given packets
        Array.Sort(arr);
 
        // Number of students cannot be
        // more than number of packets
        if (n < m)
            return -1;
		
		// Largest number of chocolates
        int min_diff = int.MaxValue;
		
		for(int i=0; i+m-1<n; i++){
			int diff = arr[i+m-1] - arr[i];
			if(diff < min_diff){
				min_diff = diff;
			}
		}
		
		return min_diff;
	}
	
	public static void Main()
    {
        int[] arr = { 12, 4,  7,  9,  2,  23, 25, 41, 30,
                      40, 28, 42, 30, 44, 48, 43, 50 };
 
        int m = 7; // Number of students
 
        int n = arr.Length;
 
        Console.WriteLine("Minimum difference is "
                          + findMinDiff(arr, n, m));
    }
}
/*
Given an array of distinct elements. The task is to find triplets in the array whose sum is zero.
*/
/*
Input: arr[] = {0, -1, 2, -3, 1}
Output: (0 -1 1), (2 -3 1)
Explanation: The triplets with zero sum are 0 + -1 + 1 = 0 and 2 + -3 + 1 = 0  

Input: arr[] = {1, -2, 1, 0, 5}
Output: 1 -2  1
Explanation: The triplets with zero sum is 1 + -2 + 1 = 0  
*/

/*
APPORACH-1 : Find all  triplets with zero sum using Hashing
*/

using System;
using System.Collections.Generic;

class GFG{
	static void findTriplets(int[] arr, int n){
		bool found = false;
		
		for(int i=0; i<=n-2; i++){
			HashSet<int> s = new HashSet<int>();
		
			for(int j=i+1; j<=n-1; j++){
				int x = -(arr[i] + arr[j]);
				
				if(s.Contains(x)){
					Console.Write("{0} {1} {2}\n",x, arr[i], arr[j]);
					found = true;
				}else{
					s.Add(arr[j])
				}
			}
		}
		
		if(found == false){
			Console.Write("No Triplet Found\n");
		}
	}
	
	public static void Main(){
		int[] arr = {0, -1, 2, -3, 1};
		int n = arr.Length;
		findtriplets(arr, n);
	}
	
}

/*
APPROACH-2 : Sort the array 
*/
class GFG{
	static findTriplets(int[] arr, int n){
		bool found = false;
		
		Array.Sort(arr);
		
		for(int i=0; i<=n-2; i++){
			int leftIndex = i+1;
			int rightIndex = n-1;
			int currentValue = arr[i];
			
			while(l<r){
				if(currentValue + arr[leftIndex] + arr[rightIndex] == 0){
					Console.Write(x + " ");
                    Console.Write(arr[l] + " ");
                    Console.WriteLine(arr[r] + " ");
					
					leftIndex++;
					rightIndex--;
					found = true;
				}
				else if(currentValue + arr[leftIndex] + arr[rightIndex] < 0)
					leftIndex++;
				else
					rightIndex--;
			}
		}	
		
		if(found == false){
			Console.Write("No Triplet Found\n");
		}
	}
	public static void Main(){
		int[] arr = { 0, -1, 2, -3, 1 };
        int n = arr.Length;
        findTriplets(arr, n);
	}
}
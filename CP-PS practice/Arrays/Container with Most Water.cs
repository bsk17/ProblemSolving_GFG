/*
Given n non-negative integers a_1, a_2, ..., a_n where each represents a point at coordinate (i, a_i). ‘ n ‘ vertical lines are drawn such that the two endpoints of line i is at (i, a_i)and (i, 0). 
Find two lines, which together with x-axis forms a container, such that the container contains the most water.
The program should return an integer which corresponds to the maximum area of water that can be contained (maximum area instead of maximum volume sounds weird but this is the 2D plane we are working with for simplicity).

Note: You may not slant the container. 
*/

/*
Approach: Given an array of heights of lines of boundaries of the container, find the maximum water that can be stored in a container. So start with the first and last element and check the amount of water that can be contained and store that container. Now the question arises is there any better boundaries or lines that can contain maximum water. So there is a clever way to find that. Initially, there are two indices the first and last index pointing to the first and the last element (which acts as boundaries of the container), if the value of first index is less than the value of last index increase the first index else decrease the last index. As the decrease in width is constant, by following the above process the optimal answer can be reached.
*/

using System;

class GFG{
	static int maxArea(int[] arr, int length){
		int l = 0;
		int r = length-1;
		int area = 0;
		
		while(l<r){
			area = Math.Max(area, (Math.Min(arr[l],arr[r])) * (r-l));
			if(arr[l]<arr[r]){
				l++;
			}
			else{
				r--;
			}
		}
		return area;
	}
	
	public static void Main(){
		int []a = {1, 5, 4, 3};
        int []b = {3, 1, 2, 4, 5};
     
        int len1 = 4;
        Console.WriteLine( maxArea(a, len1));
     
        int len2 = 5;
        Console.WriteLine( maxArea(b, len2) );
	}
}
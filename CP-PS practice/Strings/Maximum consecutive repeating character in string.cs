/*
Given a string, the task is to find the maximum consecutive repeating character in a string.
Note: We do not need to consider the overall count, but the count of repeating that appears in one place.
Examples: 
 

Input : str = "geeekk"
Output : e
Input : str = "aaaabbcbbb"
Output : a
*/

/*
An efficient solution is to run only one loop. The idea is to reset the count as 1 as soon as we find a character not matching with the previous. 
*/


using System;

class GFG 
{

// function to find out the 
// maximum repeating character
// in given string
static char maxRepeating(string str)
{
	int n = str.Length;
	int count = 0;
	char res = str[0];
	int currentCount = 1;
	
	for(int i=0; i<n; i++){
		if(i<n-1 && str[i]==str[i+1]){
			currentCount++;
		}
		else{
			if(currentCount > count){
				count = currentCount;
				res = str[i];
			}
			currentCount = 1;
		}
	}
	
	return res;
}

// Driver code
public static void Main()
{
	string str = "aaaabbaaccde";
	Console.Write(maxRepeating(str));
}
}

// This code is contributed 
// by ChitraNayal

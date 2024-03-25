
/*
Given a 2D array, print it in spiral form.

Examples: 

Input:  {{1,    2,   3,   4},
              {5,    6,   7,   8},
             {9,   10,  11,  12},
            {13,  14,  15,  16 }}
			
Output: 1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10 
*/

/*
Follow the given steps to solve the problem:

create a recursive function that takes a matrix and some variables (k – starting row index, m – ending row index, l – starting column index, n – ending column index) as parameters
Check the base cases (starting index is less than or equal to the ending index) and print the boundary elements in a clockwise manner
Print the top row, i.e. Print the elements of the kth row from column index l to n, and increase the count of k
Print the right column, i.e. Print the last column or n-1th column from row index k to m and decrease the count of n
Print the bottom row, i.e. if k > m, then print the elements of m-1th row from column n-1 to l and decrease the count of m
Print the left column, i.e. if l < n, then print the elements of the lth column from m-1th row to k and increase the count of l
Call the function recursively with the values of starting and ending indices of rows and columns

*/


// C# program for the above approach
using System;

class GFG {
	static int R = 4;
	static int C = 4;

	// Function for printing matrix in spiral
	// form i, j: Start index of matrix, row
	// and column respectively m, n: End index
	// of matrix row and column respectively
	static void print(int[, ] arr, int i, int j, int m,
					int n)
	{
		// If i or j lies outside the matrix
		if (i >= m || j >= n) {
			return;
		}

		// Print First Row
		for (int p = i; p < n; p++) {
			Console.Write(arr[i, p] + " ");
		}

		// Print Last Column
		for (int p = i + 1; p < m; p++) {
			Console.Write(arr[p, n - 1] + " ");
		}

		// Print Last Row, if Last and
		// First Row are not same
		if ((m - 1) != i) {
			for (int p = n - 2; p >= j; p--) {
				Console.Write(arr[m - 1, p] + " ");
			}
		}

		// Print First Column, if Last and
		// First Column are not same
		if ((n - 1) != j) {
			for (int p = m - 2; p > i; p--) {
				Console.Write(arr[p, j] + " ");
			}
		}
		print(arr, i + 1, j + 1, m - 1, n - 1);
	}

	// Driver Code
	public static void Main(String[] args)
	{
		int[, ] a = { { 1, 2, 3, 4 },
					{ 5, 6, 7, 8 },
					{ 9, 10, 11, 12 },
					{ 13, 14, 15, 16 } };

		// Function Call
		print(a, 0, 0, R, C);
	}
}


/*
Given a matrix of size N X M, find the transpose of the matrix
Transpose of a matrix is obtained by changing rows to columns and columns to rows. In other words, transpose of A[N][M] is obtained by changing A[i][j] to A[j][i].
*/

/*
APPROACH-1
Run a nested loop using two integer pointers i and j for 0 <= i < N and 0 <= j < M
Set B[i][j] equal to A[j][i]
*/
 
using System; 
class GFG { 

	static int N = 4; 

	// This function stores transpose 
	// of A[][] in B[][] 
	static void transpose(int[, ] A, int[, ] B) 
	{ 
		int i, j; 
		for (i = 0; i < N; i++) 
			for (j = 0; j < N; j++) 
				B[i, j] = A[j, i]; 
	} 

	// Driver code 
	public static void Main() 
	{ 
		int[, ] A = { { 1, 1, 1, 1 }, 
					{ 2, 2, 2, 2 }, 
					{ 3, 3, 3, 3 }, 
					{ 4, 4, 4, 4 } }; 

		int[, ] B = new int[N, N]; 

		// Function call 
		transpose(A, B); 

		Console.WriteLine("Result matrix is \n"); 
		for (int i = 0; i < N; i++) { 
			for (int j = 0; j < N; j++) 
				Console.Write(B[i, j] + " "); 
			Console.Write("\n"); 
		} 
	} 
} 

/*
APPROACH-2
Program to find the transpose of a matrix using constant space:
Note – This approach works only for square matrices (i.e., – where no. of rows are equal to the number of columns). This algorithm is also known as an “in-place” algorithm as it uses no extra space to solve the problem.

Follow the given steps to solve the problem:

Run a nested loop using two integer pointers i and j for 0 <= i < N and i+1 <= j < N
Swap A[i][j] with A[j][i]
*/
 
using System; 

class GFG { 

	static int N = 4; 

	// Finds transpose of A[][] in-place 
	static void transpose(int[, ] A) 
	{ 
		for (int i = 0; i < N; i++) 
			for (int j = i + 1; j < N; j++) { 
				int temp = A[i, j]; 
				A[i, j] = A[j, i]; 
				A[j, i] = temp; 
			} 
	} 

	// Driver code 
	public static void Main() 
	{ 
		int[, ] A = { { 1, 1, 1, 1 }, 
					{ 2, 2, 2, 2 }, 
					{ 3, 3, 3, 3 }, 
					{ 4, 4, 4, 4 } }; 

		transpose(A); 

		Console.WriteLine("Modified matrix is "); 
		for (int i = 0; i < N; i++) { 
			for (int j = 0; j < N; j++) 
				Console.Write(A[i, j] + " "); 

			Console.WriteLine(); 
		} 
	} 
} 

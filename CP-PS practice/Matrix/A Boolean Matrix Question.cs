/*
Given a boolean matrix mat[M][N] of size M X N, modify it such that if a matrix cell mat[i][j] is 1 (or true) then make all the cells of ith row and jth column as 1. 
*/

/*
Follow the steps below to solve the problem

Create two temporary arrays row[M] and col[N]. Initialize all values of row[] and col[] as 0. 
Traverse the input matrix mat[M][N]. If you see an entry mat[i][j] as true, then mark row[i] and col[j] as true. 
Traverse the input matrix mat[M][N] again. For each entry mat[i][j], check the values of row[i] and col[j]. If any of the two values (row[i] or col[j]) is true, then mark mat[i][j] as true.

Time Complexity: O(M*N), Traversing over the matrix two times.
Auxiliary Space: O(M + N), Taking two arrays one of size M and another of size N.
*/



using System;

class GFG {
	public static void modifyMatrix(int[, ] mat, int R,
									int C)
	{
		int[] row = new int[R];
		int[] col = new int[C];
		int i, j;

		/* Initialize all values
		of row[] as 0 */
		for (i = 0; i < R; i++) {
			row[i] = 0;
		}

		/* Initialize all values
		of col[] as 0 */
		for (i = 0; i < C; i++) {
			col[i] = 0;
		}

		/* Store the rows and columns
		to be marked as 1 in row[]
		and col[] arrays respectively */
		for (i = 0; i < R; i++) {
			for (j = 0; j < C; j++) {
				if (mat[i, j] == 1) {
					row[i] = 1;
					col[j] = 1;
				}
			}
		}

		/* Modify the input matrix
		mat[] using the above
		constructed row[] and
		col[] arrays */
		for (i = 0; i < R; i++) {
			for (j = 0; j < C; j++) {
				if (row[i] == 1 || col[j] == 1) {
					mat[i, j] = 1;
				}
			}
		}
	}

	/* A utility function to
	print a 2D matrix */
	public static void printMatrix(int[, ] mat, int R,
								int C)
	{
		int i, j;
		for (i = 0; i < R; i++) {
			for (j = 0; j < C; j++) {
				Console.Write(mat[i, j] + " ");
			}
			Console.WriteLine();
		}
	}

	// Driver code
	static public void Main()
	{
		int[, ] mat = { { 1, 0, 0, 1 },
						{ 0, 0, 1, 0 },
						{ 0, 0, 0, 0 } };

		Console.WriteLine("Matrix Initially");

		printMatrix(mat, 3, 4);

		modifyMatrix(mat, 3, 4);
		Console.WriteLine("Matrix after "
						+ "modification");
		printMatrix(mat, 3, 4);
	}
}


/*Find the factorial of a large number. */

/*USE BIG INTEGER*/

using System;
using System.Collections.Generic;
using System.Numerics;

public class Example {

// Returns Factorial of N
static BigInteger factorial(int N)
{

	// Initialize result
	BigInteger f
	= new BigInteger(1); // Or BigInteger.ONE

	// Multiply f with 2, 3, ...N
	for (int i = 2; i <= N; i++)
	f = BigInteger.Multiply(f, new BigInteger(i));

	return f;
}

// Driver method
public static void Main(string[] args)
{
	int N = 20;
	Console.WriteLine(factorial(N));
}
}

// This code is contributed by phasing17

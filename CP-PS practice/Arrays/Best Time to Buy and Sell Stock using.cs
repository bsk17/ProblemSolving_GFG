/*Given an array prices[] of length N, representing the prices of the stocks on different days, the task is to find the maximum profit possible by buying and selling the stocks on different days when at most one transaction is allowed.*/

/*Input: prices[] = {7, 1, 5, 3, 6, 4}
Output: 5
Explanation:
The lowest price of the stock is on the 2nd day, i.e. price = 1. Starting from the 2nd day, the highest price of the stock is witnessed on the 5th day, i.e. price = 6. 
Therefore, maximum possible profit = 6 – 1 = 5. 

Input: prices[] = {7, 6, 4, 3, 1} 
Output: 0
Explanation: Since the array is in decreasing order, no possible way exists to solve the problem.

*/

/*In order to maximize the profit, we have to minimize the cost price and maximize the selling price. So at every step, we will keep track of the minimum buy price of stock encountered so far. If the current price of stock is lower than the previous buy price, then we will update the buy price, else if the current price of stock is greater than the previous buy price then we can sell at this price to get some profit. After iterating over the entire array, return the maximum profit.*/

using System;
public class GFG {

	static int maxProfit(int[] prices, int n)
	{
		int buyDatePrice = prices[0], max_profit = 0;
		for (int i = 1; i < n; i++) {

			// Checking for lower buy value
			if (prices[i] < buyDatePrice)
				buyDatePrice = prices[i];

			// Checking for higher profit
			else if (prices[i] - buyDatePrice > max_profit)
				max_profit = prices[i] - buyDatePrice;
		}
		return max_profit;
	}

	static public void Main()
	{

		// Code
		int[] prices = { 7, 1, 5, 6, 4 };
		int n = prices.Length;
		int max_profit = maxProfit(prices, n);
		Console.WriteLine(max_profit);
	}
}

// This code is contributed by lokeshmvs21.

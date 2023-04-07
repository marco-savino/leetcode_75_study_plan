/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 
Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.

 

Constraints:

    1 <= prices.length <= 105
    0 <= prices[i] <= 104
*/

public class Solution09b {
    public int MaxProfit(int[] prices) 
    {
        int minPrice, deltaPrice, maxDeltaPrice;

        minPrice = Int32.MaxValue; // minPrice must be the highest possible in order to be instantly overwritten
        maxDeltaPrice = 0;  // In the same way, maxDeltaPrice must start from the lowest possible value

        for(int i=0; i<prices.Length; i++)
        {
            if(prices[i] < minPrice) // The minPrices are the starting points of the window, so we always must ask first if we found a better starting point
                minPrice = prices[i]; // If we found it, then the window resets and there is nothing more to do in this iteration
            else 
            {
                deltaPrice = prices[i] - minPrice; // This is the key variable of what we are looking for
                if(deltaPrice > maxDeltaPrice)
                    maxDeltaPrice = deltaPrice;
            }
                
        }

        return maxDeltaPrice;
    }
}
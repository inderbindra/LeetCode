// Last updated: 12/11/2025, 8:01:54 PM
public enum Option
{
    Buy=0,
    Sell
}
public class Solution {
    Dictionary<(int, Option), int> dp;
    public int MaxProfit(int[] prices) {
        dp = new();
        return FindMaxProfit(prices, 0, Option.Buy);
    }

    private int FindMaxProfit(int[] prices, int index, Option option)
    {
        if(index >= prices.Length)
        {
            return 0;
        }
        if(dp.ContainsKey((index, option)))
        {
            return dp[(index, option)];
        }
      
        int profit=0, maxProfit =0;
        if(option == Option.Buy)
        {
            profit = Math.Max(FindMaxProfit(prices, index+1, Option.Sell) - prices[index], FindMaxProfit(prices, index+1, Option.Buy));
        }
        else if(option == Option.Sell)
        {
            profit = Math.Max(prices[index] + FindMaxProfit(prices, index+2, Option.Buy), FindMaxProfit(prices, index+1, Option.Sell));
        }
        maxProfit = Math.Max(maxProfit, profit);
        dp[(index, option)] = maxProfit;
        return maxProfit;
    }
}
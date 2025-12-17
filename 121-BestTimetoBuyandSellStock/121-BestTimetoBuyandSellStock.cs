// Last updated: 12/16/2025, 7:35:39 PM
1public class Solution {
2    public int MaxProfit(int[] prices) {
3        int left=0, right=1, profit=0, maxProfit = 0;
4
5        while(right < prices.Length)
6        {
7            profit = prices[right] - prices[left];
8            maxProfit = Math.Max(maxProfit, profit);
9            if(prices[left] > prices[right])
10            {
11                left = right;
12            }
13            right++;
14        }
15        return maxProfit;
16    }
17}
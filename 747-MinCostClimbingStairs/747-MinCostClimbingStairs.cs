// Last updated: 12/11/2025, 8:00:47 PM
public class Solution {
    int[] dp;
    public int MinCostClimbingStairs(int[] cost) {
        dp = new int[cost.Length];
        Array.Fill(dp, -1);
        return Math.Min(MinCost(cost, 0), MinCost(cost, 1));
    }
    private int MinCost(int[] cost, int index)
    {
        int minCost =0;
        if(index >= cost.Length)
        {
            return 0;
        }
        if(dp[index] != -1)
        {
            return dp[index];
        }
        minCost = cost[index] + Math.Min(MinCost(cost, index+1), MinCost(cost, index+2));
        dp[index] = minCost;
        return minCost;
    }
}
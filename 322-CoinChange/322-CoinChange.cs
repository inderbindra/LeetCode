// Last updated: 12/11/2025, 8:01:53 PM
public class Solution {
    int[] dp;
    public int CoinChange(int[] coins, int amount) {
        dp = new int[amount + 1];
        Array.Fill(dp, -1);
        int minCoins = FindMinCoins(coins, amount);
        return minCoins == int.MaxValue ? -1 : minCoins;
    }
    private int FindMinCoins(int[] coins, int amount)
    {
        if(amount == 0)
        {
            return 0;
        }
        if(amount < 0)
        {
            return int.MaxValue;
        }
        if(dp[amount] != -1)
        {
            return dp[amount];
        }
        int minCoins = int.MaxValue, usedCoins = int.MaxValue;

        for(int i=0; i<coins.Length; i++)
        {
            usedCoins = FindMinCoins(coins, amount - coins[i]);
            if(usedCoins != int.MaxValue && usedCoins + 1 < minCoins)
            {
                minCoins = usedCoins + 1;
            }
        }
        dp[amount] = minCoins;
        return minCoins;
    }
}
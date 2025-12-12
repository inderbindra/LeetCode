// Last updated: 12/11/2025, 8:01:54 PM
public class Solution {
    int[,] dp;
    public int MaxCoins(int[] nums) {
        List<int> numList = new List<int>();
        numList.Add(1);
        numList.AddRange(nums);
        numList.Add(1);
        dp = new int[numList.Count, numList.Count];
        return FindMaxCoins(numList, 1, numList.Count -2);
    }
    private int FindMaxCoins(IList<int> nums, int left, int right)
    {
        if(left > right)
        {
            return 0;
        }
        if(dp[left, right] != 0)
        {
            return dp[left, right];
        }
        int coins =0;
        for(int i=left; i<=right; i++)
        {
            coins = nums[left-1] * nums[i] * nums[right+1];
            coins += FindMaxCoins(nums, left, i-1) + FindMaxCoins(nums, i+1, right);
            dp[left, right] = Math.Max(dp[left, right], coins);
        }
        return dp[left, right];
    }
}
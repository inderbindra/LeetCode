// Last updated: 12/11/2025, 8:01:57 PM
public class Solution {
    int[] dp;
    public int LengthOfLIS(int[] nums) {
        dp = new int[nums.Length];
        Array.Fill(dp, -1);
        return CalculateLength(nums, int.MinValue, 0);
    }
    private int CalculateLength(int[] nums, int prevVal, int index)
    {
        int len=0, maxLen=0;
        if(index >= nums.Length)
        {
            return 0;
        }
        if(dp[index] != -1)
        {
            return dp[index];
        }
        for(int i=index; i<nums.Length; i++)
        {
            if(prevVal < nums[i])
            {
                len = 1 + CalculateLength(nums, nums[i], i+1);
                maxLen = Math.Max(maxLen, len);
            }
        }
        dp[index] = maxLen;
        return maxLen;
    }
}
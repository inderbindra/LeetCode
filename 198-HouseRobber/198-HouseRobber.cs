// Last updated: 12/11/2025, 8:02:27 PM
public class Solution {
    int[] dp;
    public int Rob(int[] nums) {
        dp = new int[nums.Length];
        Array.Fill(dp, -1);
        return Math.Max(RobHouse(nums, 0), RobHouse(nums, 1));
    }
    private int RobHouse(int[] nums, int index)
    {
        if(index >= nums.Length)
        {
            return 0;
        }
        if(dp[index] != -1)
        {
            return dp[index];
        }

        int amount = nums[index] + Math.Max(RobHouse(nums, index + 2),RobHouse(nums, index + 3));
        dp[index] = amount;
        return amount;
    }
}
// Last updated: 12/11/2025, 8:02:15 PM
public class Solution {
    int[] dp;
    public int Rob(int[] nums) {
        //Edge Case
        if(nums.Length == 1)
        {
            return nums[0];
        }
        dp = new int[nums.Length];
        Array.Fill(dp, -1);
        int skipFirstHouse = Math.Max(RobHouse(nums, 1, nums.Length), RobHouse(nums, 2, nums.Length));
        Array.Fill(dp, -1);
        int skipLastHouse = Math.Max(RobHouse(nums, 0, nums.Length-1), RobHouse(nums, 1, nums.Length-1));
        return Math.Max(skipFirstHouse, skipLastHouse);
    }
    private int RobHouse(int[] nums, int start, int end)
    {
        if(start >= end)
        {
            return 0;
        }
        if(dp[start] != -1)
        {
            return dp[start];
        }
        int amount = nums[start] + Math.Max(RobHouse(nums, start + 2, end), RobHouse(nums, start + 3, end));
        dp[start] = amount;
        return amount;
    }
}
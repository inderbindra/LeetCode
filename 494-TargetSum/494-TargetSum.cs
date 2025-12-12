// Last updated: 12/11/2025, 8:01:03 PM
public class Solution {
    Dictionary<(int target, int index), int> dp;
    public int FindTargetSumWays(int[] nums, int target) {
        int[] symbols = new int[] {1, -1};
        dp = new();
        return FindWays(nums, symbols, target, 0);
    }   
    private int FindWays(int[] nums, int[] symbols, int target, int index)
    {
        if(index >= nums.Length)
        {
            if(target == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        if(dp.ContainsKey((target, index)))
        {
            return dp[(target, index)];
        }
        int val = 0, ways= 0;
        for(int k=0; k<symbols.Length; k++)
        {
            val = nums[index] * symbols[k];
            ways += FindWays(nums, symbols, target - val, index+1);
        }
        dp[(target, index)] = ways;
        return ways;
    }
}
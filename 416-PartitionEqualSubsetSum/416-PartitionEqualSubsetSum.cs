// Last updated: 12/11/2025, 8:01:37 PM
public class Solution {
    Dictionary<(int index, int target), bool> dp;
    public bool CanPartition(int[] nums) {
        int sum = nums.Sum();
        if(sum % 2 != 0)
        {
            return false;
        }
        dp = new();
        bool result = CheckPartition(nums, sum/2, 0);
        return result;
    }
    private bool CheckPartition(int[] nums, int target, int index)
    {
        if(target == 0)
        {
            return true;
        }
        if(target < 0 || index == nums.Length)
        {
            return false;
        }
        if(dp.ContainsKey((index, target)))
        {
            return dp[(index, target)];
        }
        bool result = false;
        result = CheckPartition(nums, target - nums[index], index+1) || CheckPartition(nums, target, index+1);
        dp[(index, target)] = result;
        return result;
    }
}
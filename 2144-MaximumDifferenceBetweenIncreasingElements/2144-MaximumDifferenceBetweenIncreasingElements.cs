// Last updated: 12/11/2025, 7:59:49 PM
public class Solution {
    public int MaximumDifference(int[] nums) {
        
        int maxDiff =-1, min = nums[0];
        for(int i=1; i<nums.Length; i++)
        {
            maxDiff = Math.Max(maxDiff, nums[i] - min);
            min = Math.Min(min, nums[i]);
        }
        return (maxDiff == 0)? -1 : maxDiff;
    }
}
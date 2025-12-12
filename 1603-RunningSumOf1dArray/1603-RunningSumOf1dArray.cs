// Last updated: 12/11/2025, 8:00:01 PM
public class Solution {
    public int[] RunningSum(int[] nums) {
        
        int[] sum = new int[nums.Length];
        
        sum[0] = nums[0];
        for(int i=1; i< nums.Length; i++)
        {
            sum[i] = sum[i-1] + nums[i];
        }
        
        return sum;
    }
}
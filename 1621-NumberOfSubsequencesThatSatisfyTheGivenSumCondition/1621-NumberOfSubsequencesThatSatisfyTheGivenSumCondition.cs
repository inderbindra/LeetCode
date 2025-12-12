// Last updated: 12/11/2025, 8:00:02 PM
public class Solution {
    public int NumSubseq(int[] nums, int target) {
        Array.Sort(nums);
        int left=0, right = nums.Length-1, result=0;
        int mod = 1000000007;
        int[] power = new int[nums.Length];
        power[0] = 1;
        for(int i=1; i<nums.Length; i++)
        {
            // We need to modulo as it is going out bounds which is giving us the incorrect result.
            power[i] = (power[i-1] * 2) % mod;
        }
        while(left <= right)
        {
            if(nums[left] + nums[right] <= target)
            {
                result += power[right-left];
                // We need to modulo as it is going out bounds which is giving us the incorrect result.
                result = result % mod;
                left++;
            }
            else
            {
                right--;
            }
        }
        return result;
    }
}
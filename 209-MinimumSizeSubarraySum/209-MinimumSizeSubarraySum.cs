// Last updated: 12/11/2025, 8:02:21 PM
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left=0, right=0, sum=0, minLen= int.MaxValue;
        while(right < nums.Length)
        {
            sum += nums[right];
            while(left <= right && sum >= target)
            {
                minLen = Math.Min(minLen, (right - left + 1));
                sum -= nums[left];
                left++;
            }
            right++;
        }
        return minLen == int.MaxValue ? 0 : minLen;
    }
}
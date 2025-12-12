// Last updated: 12/11/2025, 8:00:45 PM
public class Solution {
    public int Search(int[] nums, int target) {
        int left=0, right = nums.Length - 1, mid=0;

        while(left <= right)
        {
            mid = left + (right - left)/2;
            if(nums[mid] ==  target)
            {
                return mid;
            }
            else if(nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}
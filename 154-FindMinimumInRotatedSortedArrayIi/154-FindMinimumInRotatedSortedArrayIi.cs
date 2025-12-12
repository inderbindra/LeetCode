// Last updated: 12/11/2025, 8:02:35 PM
public class Solution {
    public int FindMin(int[] nums) {
        int left=0, right=nums.Length-1, mid=0;

        while(left < right)
        {
            mid = (left + right) /2;
            // If duplicate number found on the left side.
            if(left < mid && nums[mid] == nums[left])
            {
                left++;
            }
            // If duplicate number found on the right side.
            else if(right > mid && nums[mid] == nums[right])
            {
                right--;
            }
            else if(nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return nums[left];  
    }
}
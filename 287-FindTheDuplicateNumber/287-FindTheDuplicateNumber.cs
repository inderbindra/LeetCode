// Last updated: 12/11/2025, 8:01:59 PM
public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow=0, fast=0;
        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        while(slow != fast);

        slow=0;
        while(slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }
        return slow;
    }
}
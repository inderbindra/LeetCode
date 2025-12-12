// Last updated: 12/11/2025, 8:02:44 PM
public class Solution {
    public int SingleNumber(int[] nums) {
        int res=0;
        for(int i=0; i<nums.Length; i++)
        {
            res = nums[i] ^ res;
        }
        return res;
    }
}
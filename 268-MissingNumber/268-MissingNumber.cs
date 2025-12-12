// Last updated: 12/11/2025, 8:02:01 PM
public class Solution {
    public int MissingNumber(int[] nums) {
        int xorRange=0, xorNums=0;

        for(int i=0; i<=nums.Length; i++)
        {
            xorRange ^= i;
        }
        for(int i=0; i<nums.Length; i++)
        {
            xorNums ^= nums[i];
        }
        return xorRange ^ xorNums;
    }
}
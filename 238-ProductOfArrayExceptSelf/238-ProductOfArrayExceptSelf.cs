// Last updated: 12/11/2025, 8:02:04 PM
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] product = new int[nums.Length];
        int num=1;

        for(int i=0; i<nums.Length; i++)
        {
            product[i] = num;
            num *= nums[i];
        }
        num=1;
        for(int i=nums.Length-1; i>=0; i--)
        {
            product[i] *= num;
            num *= nums[i];
        }
        return product;
    }
}
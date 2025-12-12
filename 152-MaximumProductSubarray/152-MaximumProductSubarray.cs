// Last updated: 12/11/2025, 8:02:38 PM
public class Solution {
    public int MaxProduct(int[] nums) {
        int leftProduct = 1, rightProduct=1, maxProduct=int.MinValue;

        for(int i=0; i<nums.Length; i++)
        {
            leftProduct *= nums[i];
            rightProduct *= nums[nums.Length - i - 1];
            maxProduct = Math.Max(maxProduct, Math.Max(leftProduct, rightProduct));
            leftProduct = (leftProduct == 0) ? 1 : leftProduct;
            rightProduct = (rightProduct == 0) ? 1 : rightProduct;
        }
        return maxProduct;
    }
}
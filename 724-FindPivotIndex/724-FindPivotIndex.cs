// Last updated: 12/11/2025, 8:00:52 PM
public class Solution {
    public int PivotIndex(int[] nums) {
       
        int sum = 0;
        for(int i=0; i< nums.Length; i++)
        {
            sum += nums[i];
        }
        
        int leftSum = 0, rightSum = 0;
        
        for(int i=0; i< nums.Length; i++)
        {
            rightSum = sum- nums[i] - leftSum;
            if(leftSum == rightSum)
            {
                return i;
            }
            
            leftSum += nums[i];
        }
        
        return -1;
    }
}
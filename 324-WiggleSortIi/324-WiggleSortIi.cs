// Last updated: 12/11/2025, 8:01:51 PM
public class Solution {
    public void WiggleSort(int[] nums) {
        
        if(nums.Length < 2)
        {
            return;
        }
        Array.Sort(nums);
        int[] result = new int[nums.Length];
        int i=0, j=1;

        for(i = nums.Length-1; i>=0; i--)
        {
            result[j] = nums[i];
            j+=2;
            if(j >= nums.Length)
            {
                j=0;
            }
        }
        for(i=0; i<nums.Length; i++)
        {
            nums[i] = result[i];
        }
    }
}

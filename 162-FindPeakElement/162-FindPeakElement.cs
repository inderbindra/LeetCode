// Last updated: 12/11/2025, 8:02:35 PM
public class Solution {
    public int FindPeakElement(int[] nums) {
        int l=0, r=nums.Length-1, mid=0;

        while(l<=r)
        {
            mid = l + (r-l)/2;
            Console.WriteLine("mid = " + mid);
            if(mid > 0 && nums[mid] < nums[mid-1])
            {
                r = mid-1;
            }
            else if(mid < nums.Length-1 && nums[mid] < nums[mid+1])
            {
                l = mid+1;
            }
            else
            {
                return mid;
            }
        }
        return 0;
    }
}
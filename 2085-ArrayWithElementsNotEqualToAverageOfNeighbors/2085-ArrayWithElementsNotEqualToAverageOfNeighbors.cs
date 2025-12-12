// Last updated: 12/11/2025, 7:59:52 PM
public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int left=0, right=nums.Length-1;
        Array.Sort(nums);
        List<int> res = new();
        while(res.Count != nums.Length)
        {
            res.Add(nums[left]);
            left++;
            if(left <= right)
            {
                res.Add(nums[right]);
                right--;
            }
        }
        return res.ToArray();
    }
}
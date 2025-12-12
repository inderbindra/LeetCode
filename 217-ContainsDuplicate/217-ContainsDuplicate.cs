// Last updated: 12/11/2025, 8:02:12 PM
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> hashSet = new();

        for(int i=0; i<nums.Length; i++)
        {
            if (hashSet.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                hashSet.Add(nums[i], 1);
            }
        }
        return false;
    }
}
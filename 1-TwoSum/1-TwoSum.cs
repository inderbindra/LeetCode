// Last updated: 12/11/2025, 8:30:34 PM
1public class Solution {
2    public int[] TwoSum(int[] nums, int target) {
3        Dictionary<int, int> hashMap = new();
4
5        int diff =0, i;
6        for(i=0; i<nums.Length; i++)
7        {
8            diff = target - nums[i];
9            if(hashMap.ContainsKey(diff))
10            {
11                break;
12            }
13            hashMap.TryAdd(nums[i], i);
14        }
15        return new int[]{i, hashMap[diff]};
16    }
17}
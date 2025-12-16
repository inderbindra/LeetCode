// Last updated: 12/15/2025, 7:04:18 PM
1public class Solution {
2    public int[] ProductExceptSelf(int[] nums) {
3        int[] result = new int[nums.Length];
4        int num=1;
5
6        for(int i=0; i<nums.Length; i++)
7        {
8            result[i] = num;
9            num *= nums[i];
10        }
11        num = 1;
12        
13        for(int i=nums.Length-1; i>=0; i--)
14        {
15            result[i] *= num;
16            num *= nums[i];
17        }
18        return result;
19    }
20}
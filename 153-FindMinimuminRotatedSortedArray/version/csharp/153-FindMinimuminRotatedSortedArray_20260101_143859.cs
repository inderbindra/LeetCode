// Last updated: 1/1/2026, 2:38:59 PM
1public class Solution {
2    public int FindMin(int[] nums) {
3        int left=0, right=nums.Length-1, mid=0;
4
5        while(left < right)
6        {
7            mid = (left + right)/2;
8
9            if(nums[mid] > nums[right])
10            {
11                left = mid + 1;
12            }
13            else
14            {
15                right = mid;
16            }
17        }
18        return nums[left];
19    }
20}
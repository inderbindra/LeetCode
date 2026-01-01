// Last updated: 1/1/2026, 3:10:08 PM
1public class Solution {
2    public int Search(int[] nums, int target) {
3        int left=0, right=nums.Length-1, mid=0;
4
5        while(left<= right)
6        {
7            mid = left + (right - left)/2;
8
9            if(nums[mid] == target)
10            {
11                return mid;
12            }
13            // Check which portion of array is sorted
14            // If right portion is sorted then 
15            else if(nums[mid] < nums[right])
16            {
17                if(target > nums[mid] && target <= nums[right])
18                {
19                    left = mid+1;
20                }
21                else
22                {
23                    right = mid - 1;
24                }
25            }
26            // If left portion is sorted then 
27            else
28            {
29                if(target < nums[mid] && target >= nums[left])
30                {
31                    right = mid-1;
32                }
33                else
34                {
35                    left = mid + 1;
36                }
37            }
38        }
39        return -1;
40    }
41}
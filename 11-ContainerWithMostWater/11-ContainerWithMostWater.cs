// Last updated: 12/15/2025, 8:46:22 PM
1public class Solution {
2    public int MaxArea(int[] height) {
3        int area=0, maxArea=0, left=0, right=height.Length-1;
4
5        while(left < right)
6        {
7            area = Math.Min(height[left], height[right]) * (right - left);
8            maxArea = Math.Max(maxArea, area);
9            if(height[left] < height[right])
10            {
11                left++;
12            }
13            else
14            {
15                right--;
16            }
17        }
18        return maxArea;
19    }
20}
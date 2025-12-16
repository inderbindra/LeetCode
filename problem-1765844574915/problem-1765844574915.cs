// Last updated: 12/15/2025, 7:22:54 PM
1public class Solution {
2    public int LongestConsecutive(int[] nums) {
3        HashSet<int> numSet = new();
4        int i=0, seq=0, longestSeq=0, num=0;
5        for(i=0; i<nums.Length; i++)
6        {
7            numSet.Add(nums[i]);
8        }
9        for(i=0; i<nums.Length; i++)
10        {
11            num = nums[i];
12            // The below condition is the optimization which avoid 
13            // iteration at both ends -ve & +ve.
14            if(!numSet.Contains(num - 1))
15            {
16                seq = 1;
17                num++;
18                while(numSet.Contains(num))
19                {
20                    seq++;
21                    num++;
22                }
23                longestSeq = Math.Max(longestSeq, seq);
24            }
25            
26        }
27        return longestSeq;
28    }
29}
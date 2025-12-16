// Last updated: 12/15/2025, 7:29:10 PM
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
14            // Checking this condition means this is the start of the sequence.
15            if(!numSet.Contains(num - 1))
16            {
17                seq = 1;
18                num++;
19                while(numSet.Contains(num))
20                {
21                    seq++;
22                    num++;
23                }
24                longestSeq = Math.Max(longestSeq, seq);
25            }
26            // Added this loop to iterate the same sequence start number like if a list contains multiple 1's, so it will only
27            // calculate the sequence only once.
28            while(i<nums.Length-1 && nums[i] == nums[i+1])
29            {
30                i++;
31            }
32        }
33        return longestSeq;
34    }
35}
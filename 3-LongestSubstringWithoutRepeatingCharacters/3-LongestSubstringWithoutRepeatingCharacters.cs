// Last updated: 12/16/2025, 8:00:34 PM
1public class Solution {
2    public int LengthOfLongestSubstring(string s) {
3        HashSet<char> hashSet =  new();
4        int left=0, right=0, length=0, maxLength=0;
5        while(right < s.Length)
6        {
7            while(hashSet.Contains(s[right]))
8            {
9                hashSet.Remove(s[left]);
10                left++;
11            }
12
13            hashSet.Add(s[right]);
14            length = hashSet.Count;
15            maxLength = Math.Max(maxLength, length);
16            right++;
17        }
18        return maxLength;
19    }
20}
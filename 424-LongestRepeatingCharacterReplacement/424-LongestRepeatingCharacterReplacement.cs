// Last updated: 12/17/2025, 6:13:27 PM
1public class Solution {
2    public int CharacterReplacement(string s, int k) {
3        Dictionary<char, int> charFreq = new();
4        int maxFreq =0, left=0, right=0, len=0, maxLength=0;
5
6        while(right < s.Length)
7        {
8            charFreq.TryAdd(s[right], 0);
9            charFreq[s[right]] += 1;
10            maxFreq = Math.Max(maxFreq, charFreq[s[right]]);
11            len = right - left + 1;
12
13            if(len - maxFreq > k)
14            {
15                charFreq[s[left]] -= 1;
16                left++;
17                maxFreq = charFreq.Values.Max();
18            }
19            len = right - left +1;
20            maxLength = Math.Max(maxLength, len);
21            right++;
22        }
23        return maxLength;
24    }
25}
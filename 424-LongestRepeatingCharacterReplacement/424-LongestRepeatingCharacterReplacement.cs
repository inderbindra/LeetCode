// Last updated: 12/11/2025, 8:01:37 PM
public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxFreq=0, left=0, right=0, len=0, maxLen=0;
        Dictionary<char, int> hashMap = new();

        while(right < s.Length)
        {
            hashMap.TryAdd(s[right], 0);
            hashMap[s[right]] += 1;
            maxFreq = Math.Max(maxFreq, hashMap[s[right]]);
            len = right - left + 1;
            while((len - maxFreq) > k)
            {
                hashMap[s[left]] -= 1;
                left++;
                maxFreq = hashMap.Values.Max();
                len = right - left + 1;
            }
            maxLen = Math.Max(maxLen, len);
            right++;
        }
        return maxLen;
    }
}
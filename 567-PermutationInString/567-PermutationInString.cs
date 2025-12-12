// Last updated: 12/11/2025, 8:00:58 PM
public class Solution {
    Dictionary<char, int> hashMap;
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length)
        {
            return false;
        }
        hashMap = new();
        for(int i=0; i<s1.Length; i++)
        {
            hashMap.TryAdd(s1[i], 0);
            hashMap[s1[i]] += 1;
        }
        int left=0, right=0, len=0;
        bool result = false;

        while(right < s2.Length)
        {
            if(hashMap.Keys.Count == 0)
            {
                return true;
            }
            UpdateMap(s2[right], -1);
            len = right-left+1;
            if(len > s1.Length)
            {
                UpdateMap(s2[left], 1);
                left++;
            }
            right++;
        }
        return (hashMap.Keys.Count == 0) ? true : false;
    }
    private void UpdateMap(char c, int val)
    {
        hashMap.TryAdd(c, 0);
        hashMap[c] += val;
        if(hashMap[c] == 0)
        {
            hashMap.Remove(c);
        }
    }
}
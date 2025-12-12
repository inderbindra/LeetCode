// Last updated: 12/11/2025, 8:02:06 PM
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> hashMap = new();

        if(s.Length != t.Length)
        {
            return false;
        }

        for(int i=0; i<s.Length; i++)
        {
            hashMap.TryAdd(s[i], 0);
            hashMap[s[i]] += 1;
        }

        for(int i=0; i<t.Length; i++)
        {
            if(!hashMap.ContainsKey(t[i]))
            {
                return false;
            }
            hashMap[t[i]] -= 1;
            if(hashMap[t[i]] == 0)
            {
                hashMap.Remove(t[i]);
            }
        }
        return true;
    }
}
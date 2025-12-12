// Last updated: 12/11/2025, 8:01:40 PM
public class Solution {
    public int FirstUniqChar(string s) {
        IDictionary<char, int> map = new Dictionary<char, int>();
        int i=0;
        for(i=0; i<s.Length; i++)
        {
            map.TryAdd(s[i], 0);
            map[s[i]] += 1;
        }
        for(i=0; i<s.Length; i++)
        {
            if(map[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}
// Last updated: 12/11/2025, 8:02:23 PM
public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
        if(s.Length != t.Length)
        {
            return false;
        }
        else
        {
            Dictionary<char, char> map1 = new Dictionary<char, char>();
            Dictionary<char, char> map2 = new Dictionary<char, char>();
            StringBuilder newStr = new StringBuilder();
            
            for(int i=0; i< s.Length; i++)
            {
                if(map1.ContainsKey(s[i]))
                {
                    newStr.Append(map1[s[i]]);
                }
                else
                {
                    if(map2.ContainsKey(t[i]))
                    {
                        return false;
                    }
                    map1.Add(s[i], t[i]);
                    map2.Add(t[i], s[i]);
                    newStr.Append(t[i]);
                }
            }
            
            if(t.Equals(newStr.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
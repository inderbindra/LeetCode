// Last updated: 12/11/2025, 8:01:42 PM
public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        if(s.Length > t.Length)
        {
            return false;
        }
        
        int charIndex = 0;
        
        IList<int> charIndexes = new List<int>();
        
        for(int i=0; i< s.Length; i++)
        {
            for(int j=charIndex; j< t.Length; j++)
            {
                if(s[i] == t[j])
                {
                    charIndex = j+1;
                    charIndexes.Add(j);
                    break;
                }
            }
        }
        
        if(charIndexes.Count == s.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
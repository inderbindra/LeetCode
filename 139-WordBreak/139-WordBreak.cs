// Last updated: 12/11/2025, 8:02:43 PM
public class Solution {
    HashSet<string> wordSet;
    Dictionary<int, bool> dp;
    public bool WordBreak(string s, IList<string> wordDict) {
        wordSet = new HashSet<string>(wordDict);
        dp = new();
        return WordBreak(s, 0);
    }
    private bool WordBreak(string s, int index)
    {
        if(index >= s.Length)
        {
            return true;
        }
        if(dp.ContainsKey(index))
        {
            return dp[index];
        }
        string subStr = string.Empty;
        bool result = false;
        for(int i=index; i<s.Length; i++)
        {
            subStr = s.Substring(index, i - index +1);
            if(wordSet.Contains(subStr))
            {
                result = WordBreak(s, i+1);
                if(result)
                {
                   break;
                }
            }
        }
        dp[index] = result;
        return result;
    }
}
// Last updated: 12/11/2025, 8:02:48 PM
public class Solution {
    Dictionary<int, IList<IList<string>>> dp;
    public IList<IList<string>> Partition(string s) {
        dp = new();
        return BackTrack(s, 0);
    }
    private IList<IList<string>> BackTrack(string s, int index)
    {
        IList<IList<string>> result = new List<IList<string>>();
        if(index == s.Length)
        {
            result.Add(new List<string>());
            return result;
        }
        if(dp.ContainsKey(index))
        {
            return dp[index];
        }
        string subStr = string.Empty;
        for(int i=index; i<s.Length; i++)
        {
            subStr = s.Substring(index, i - index + 1);
            if(IsPalindrome(subStr))
            {
                var res = BackTrack(s, i+1);
                // This loop is added to merge the subStr with the lst data returned from dp.
                // Then add it to the result.
                foreach(var lst in res)
                {
                    var currList = new List<string>{subStr};
                    currList.AddRange(lst);
                    result.Add(currList);
                }
            }
        }
        dp[index] = result;
        return result;
    }
    private bool IsPalindrome(string s)
    {
        int left=0, right=s.Length-1;
        while(left < right)
        {
            if(s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

}
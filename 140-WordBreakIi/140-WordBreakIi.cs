// Last updated: 12/11/2025, 8:02:42 PM
public class Solution {
    HashSet<string> hashSet;
    IList<string> result;
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        hashSet = new(wordDict);
        result = new List<string>();
        BreakWord(s, new List<string>(), 0);
        return result;
    }
    private void BreakWord(string s, IList<string> currentList, int index)
    {
        if(index >= s.Length)
        {
            string sList = string.Join(" ", currentList);
            result.Add(sList);
            return;
        }
        string substr;
        for(int i=index; i<s.Length; i++)
        {
            substr = s.Substring(index, i-index + 1);
            if(hashSet.Contains(substr))
            {
                currentList.Add(substr);
                BreakWord(s, currentList, i+1);
                currentList.RemoveAt(currentList.Count - 1);
            }
        }
    }
}
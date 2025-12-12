// Last updated: 12/11/2025, 8:00:40 PM
public class Solution {
    public int MinimumLengthEncoding(string[] words) {
        
        IList<string> wordList = words.Distinct().ToList();
        
        IDictionary<string, int> duplicateList = new Dictionary<string, int>();
        
        for(int i=0; i<wordList.Count(); i++)
        {
            for(int j=0; j<wordList.Count(); j++)
            {
                if(i != j)
                {
                    if(wordList[i].EndsWith(wordList[j], StringComparison.OrdinalIgnoreCase))
                    {
                        duplicateList[words[j]] =1;
                    }
                }
            }
        }
        
        int count =0;
        for(int i=0; i<wordList.Count(); i++)
        {
            if(duplicateList.ContainsKey(wordList[i]))
            {
                continue;
            }
            count += wordList[i].Count() + 1;
        }
        
        return count;
    }
}
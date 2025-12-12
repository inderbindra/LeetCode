// Last updated: 12/11/2025, 8:00:45 PM
public class Solution {
    public IList<int> PartitionLabels(string s) {
        IList<int> result = new List<int>();
        Dictionary<char, int> lastIndexMap = new();
        for(int i=0; i<s.Length; i++)
        {
            lastIndexMap[s[i]] = i;
        }
        int start=0, maxIndex=0;
        for(int i=0; i<s.Length; i++)
        {
            maxIndex = Math.Max(maxIndex, lastIndexMap[s[i]]);
            if(i == maxIndex)
            {
                result.Add(i - start + 1);
                start = i + 1;
            }
        }
        return result;
    }
}
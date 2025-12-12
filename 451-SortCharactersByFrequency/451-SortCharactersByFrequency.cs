// Last updated: 12/11/2025, 8:01:34 PM
public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> charFreq = new Dictionary<char, int>();
        PriorityQueue<char, int> pq = new PriorityQueue<char, int>();
        StringBuilder sortedStr = new StringBuilder();
        for(int i=0; i<s.Length; i++)
        {
            charFreq.TryAdd(s[i], 0);
            charFreq[s[i]] += 1;
        }
        foreach(var item in charFreq)
        {
            pq.Enqueue(item.Key, -item.Value);
        }
        while(pq.Count > 0)
        {
            if(pq.TryDequeue(out char letter, out int freq))
            {
                sortedStr.Append(letter, Math.Abs(freq));
            }
        }
        return sortedStr.ToString();
    }
}
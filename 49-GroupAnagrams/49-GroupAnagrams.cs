// Last updated: 12/11/2025, 8:39:45 PM
1public class Solution {
2    public IList<IList<string>> GroupAnagrams(string[] strs) {
3        Dictionary<string, IList<string>> hashMap = new();
4
5        char[] sortedChars;
6        string sortedString = string.Empty;
7        for(int i=0; i<strs.Length; i++)
8        {
9            sortedChars = strs[i].ToCharArray();
10            Array.Sort(sortedChars);
11            sortedString = new String(sortedChars);
12            
13            hashMap.TryAdd(sortedString, new List<string>());
14            hashMap[sortedString].Add(strs[i]);
15        }
16        return hashMap.Values.ToArray();
17    }
18}
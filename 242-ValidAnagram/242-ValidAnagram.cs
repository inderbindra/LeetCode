// Last updated: 12/11/2025, 8:11:31 PM
1public class Solution {
2    public bool IsAnagram(string s, string t) {
3        Dictionary<char, int> hashMap = new();
4
5        if(s.Length != t.Length)
6        {
7            return false;
8        }
9        for(int i=0; i<s.Length; i++)
10        {
11            hashMap.TryAdd(s[i], 0);
12            hashMap[s[i]] += 1;
13        }
14        Console.WriteLine("hello");
15        for(int i=0; i<t.Length; i++)
16        {
17            if(!hashMap.ContainsKey(t[i]))
18            {
19                return false;
20            }
21            hashMap[t[i]] -= 1;
22            if(hashMap[t[i]] == 0)
23            {
24                hashMap.Remove(t[i]);
25            }
26        }
27        return (hashMap.Keys.Count == 0)? true:false;
28    }
29}
// Last updated: 12/18/2025, 3:55:36 PM
1public class Solution {
2    public string MinWindow(string s, string t) {
3        Dictionary<char, int> tMap = new();
4        Dictionary<char, int> sMap = new();
5
6        int need=0, have=0, left=0, right=0;
7        string substr = string.Empty;
8        string result = string.Empty;
9
10        if(t.Length > s.Length)
11        {
12            return "";
13        }
14
15        for(int i=0; i<t.Length; i++)
16        {
17            tMap.TryAdd(t[i], 0);
18            tMap[t[i]] += 1;
19            need++;
20        }
21
22        while(right < s.Length)
23        {
24            if(tMap.ContainsKey(s[right]))
25            {
26                sMap.TryAdd(s[right], 0);
27                sMap[s[right]] += 1;
28
29                if(tMap[s[right]] >= sMap[s[right]])
30                {
31                    have++;
32                }
33            }
34            while(need == have && left <= right)
35            {
36                if(tMap.ContainsKey(s[left]))
37                {
38                    sMap[s[left]] -= 1;
39                    if(tMap[s[left]] > sMap[s[left]])
40                    {
41                        have--;
42                    }
43                    if(sMap[s[left]] == 0)
44                    {
45                        sMap.Remove(s[left]);
46                    }
47                }
48
49                substr = s.Substring(left, right - left + 1);
50
51                if(string.IsNullOrWhiteSpace(result) || result.Length > substr.Length)
52                {
53                    result = substr;
54                }
55                left++;
56            }
57            right++;
58        }
59        return result;
60    }
61}
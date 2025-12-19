// Last updated: 12/18/2025, 7:19:37 PM
1public class Solution {
2    public bool IsValid(string s) {
3        Dictionary<char, char> hashMap = new();
4        Stack<char> stack = new();
5
6        hashMap.Add(')', '(');
7        hashMap.Add('}', '{');
8        hashMap.Add(']', '[');
9
10        for(int i=0; i<s.Length; i++)
11        {
12            if(hashMap.ContainsKey(s[i]) && stack.Count > 0 && hashMap[s[i]] == stack.Peek())
13            {
14                stack.Pop();
15                continue;
16            }
17            stack.Push(s[i]);
18        }
19        return stack.Count == 0? true : false;
20    }
21}
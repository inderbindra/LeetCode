// Last updated: 12/15/2025, 8:06:43 PM
1public class Solution {
2    public bool IsPalindrome(string s) {
3        
4        StringBuilder str = new();
5        for(int i=0; i<s.Length; i++)
6        {
7            if(char.IsLetterOrDigit(s[i]))
8            {
9                str.Append(char.ToLower(s[i]));
10            }
11        }
12        int left=0, right = str.Length-1;
13
14        while(left < right)
15        {
16            if(str[left] != str[right])
17            {
18                return false;
19            }
20            left++;
21            right--;
22        }
23        return true;
24    }
25}